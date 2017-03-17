using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
using System.Data.Entity.Infrastructure;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;
using PT_Camping.Model;
using System.IO;
using PT_Camping.Properties;

namespace PT_Camping
{
    /// <summary>
    /// The MapUserControl is a UserControl handling the campground's map.
    /// It allows visualizing the map with the infrastrures,
    /// adding, removing, modifying a camping accommodation.
    /// 
    /// </summary>
    /// Authors : Arthur, Alexandre
    /// Since : 09/02/17
    /// 
    public enum MapMode
    {
        LoadImage,
        Normal,
        Edit
    };

    public enum CursorAction
    {
        Default,
        Move,
        ResizeN,
        ResizeE,
        ResizeS,
        ResizeW
    };

    public partial class MapUserControl : UserControl
    {
        private HomeUserControl mHomeUserControl;
        private DataBase db;
        private Bitmap image;
        private MapMode mode;
        private List<GraphicLocation> locationsList;
        private GraphicLocation _selectedLocation;
        private GraphicLocation SelectedLocation
        {
            set
            {
                _selectedLocation = value;
                if (_selectedLocation != null)
                {
                    UpdateRightMenu();
                }
            }
            get
            {
                return _selectedLocation;
            }
        }
        private bool moving;
        private PointF offsetMoving;
        private PointF startClick;
        private SizeF oldSize;
        private PointF oldPosition;
        private CursorAction cursorAction;
        private bool updatingRightMenu = false;

        public MapUserControl(HomeUserControl homeUserControl)
        {
            InitializeComponent();
            LoginTools.checkConnection();
            db = new DataBase();

            cursorAction = CursorAction.Default;
            moving = false;
            offsetMoving = new Point();
            mHomeUserControl = homeUserControl;
            Dock = DockStyle.Fill;

            FillListsControlsDromDB();

            LoadLocationsFromDb();

            if (!db.App.Any(m => m.Fond_Image != null))
            {
                mode = MapMode.LoadImage;
            }
            else
            {
                MemoryStream ms = new MemoryStream(db.App.FirstOrDefault().Fond_Image);
                var imageJpeg = Image.FromStream(ms);
                image = new Bitmap(imageJpeg);
                ms.Close();
                pictureBox.Image = image;
                mode = MapMode.Normal;
            }
            ChangeMode(mode);
        }

        private void LoadLocationsFromDb()
        {
            LoginTools.checkConnection();
            locationsList = new List<GraphicLocation>();
            foreach (Emplacement loc in db.Emplacement)
            {
                locationsList.Add(new GraphicLocation(loc));
            }
            SelectedLocation = null;
            pictureBox.Refresh();
        }

        private void FillListsControlsDromDB()
        {
            incidentsListBox.DisplayMember = "Description_Incident";

            carCheckedListBox.Items.Clear();
            foreach (Caracteristique_Emplacement car in db.Caracteristique_Emplacement)
            {
                carCheckedListBox.Items.Add(car);
            }
            carCheckedListBox.DisplayMember = "Description";

            addLocationPanel.Controls.Clear();
            typeLocationComboBox.Items.Clear();
            categoriesCheckedListBox.Items.Clear();
            List<Type_Emplacement> typesLocations = db.Type_Emplacement.ToList();
            int i = 0;
            foreach (Type_Emplacement type in typesLocations)
            {
                typeLocationComboBox.Items.Add(type);

                TableLayoutPanel panelType = CreateInsertLocationButton(type);
                addLocationPanel.Controls.Add(panelType);
                i++;

                categoriesCheckedListBox.Items.Add(type.Libelle_Type, true);
            }
            typeLocationComboBox.DisplayMember = "Libelle_Type";
            typeLocationComboBox.ValueMember = "Code_Type";
        }

        private TableLayoutPanel CreateInsertLocationButton(Type_Emplacement type)
        {
            TableLayoutPanel typePanel = new TableLayoutPanel();
            PictureBox typePicture = new PictureBox();
            Label typeLabel = new Label();

            // 
            // panel
            // 
            typePanel.ColumnCount = 2;
            typePanel.Size = new Size(150, 50);
            typePanel.ColumnStyles.Add(new ColumnStyle(SizeType.Absolute, 50));
            typePanel.ColumnStyles.Add(new ColumnStyle(SizeType.AutoSize));
            typePanel.Controls.Add(typePicture, 0, 0);
            typePanel.Controls.Add(typeLabel, 1, 0);
            typePanel.RowCount = 1;
            typePanel.RowStyles.Add(new RowStyle(SizeType.Percent, 50F));
            typePanel.TabIndex = 0;
            typePanel.Dock = DockStyle.Top;
            typePanel.Anchor = AnchorStyles.Top | AnchorStyles.Left;
            typePanel.Margin = new Padding(5);
            typePanel.BackColor = Color.Gray;

            typePanel.MouseEnter += PanelType_MouseEnter;
            typePanel.MouseLeave += PanelType_MouseLeave;
            typePanel.MouseDown += TypePanel_MouseDown;

            foreach (Control control in typePanel.Controls)
            {
                control.MouseEnter += PanelType_MouseEnter;
                control.MouseDown += TypePanel_MouseDown;
                control.MouseLeave += PanelType_MouseLeave;
            }
            // 
            // pictureBox
            // 
            typePicture.Dock = DockStyle.Fill;
            typePicture.TabIndex = 0;
            typePicture.TabStop = false;
            typePicture.SizeMode = PictureBoxSizeMode.StretchImage;
            if (type.Icone != null)
            {
                MemoryStream ms = new MemoryStream(type.Icone);
                typePicture.Image = new Bitmap(ms);
                ms.Close();
            }
            else
            {
                using (FileDialog fd = new OpenFileDialog())
                {
                    fd.Title = Resources.select_image_for_the_type + type.Libelle_Type;
                    fd.Filter = Resources.images_files_formats;
                    if (fd.ShowDialog() == DialogResult.OK)
                    {
                        try
                        {
                            image = new Bitmap(fd.FileName);
                            if (image == null)
                            {
                                throw new FileLoadException();
                            }
                            image.SetResolution(50, 50);
                            ImageConverter converter = new ImageConverter();
                            type.Icone = (byte[])converter.ConvertTo(image, typeof(byte[]));
                            db.SaveChanges();
                            typePicture.Image = image;
                        }
                        catch (FileNotFoundException)
                        {
                            MessageBox.Show(Resources.file_not_found_please_retry);
                        }
                        catch (FileLoadException)
                        {
                            MessageBox.Show(Resources.error_when_opening_the_file_please_retry);
                        }
                    }
                }
            }
            // 
            // label
            // 
            typeLabel.Anchor = AnchorStyles.Right;
            typeLabel.AutoSize = true;
            typeLabel.TabIndex = 1;
            typeLabel.Text = type.Libelle_Type;
            typeLabel.ForeColor = Color.White;
            typeLabel.Name = "typeLabel";

            return typePanel;
        }

        private void TypePanel_MouseDown(object sender, MouseEventArgs e)
        {
            Panel panel = getParentTypePanel(sender);
            if (e.Clicks == 2)
            {
                LoginTools.checkConnection();
                Label typeLabel = (Label) panel.Controls.Find("typeLabel", true).First();
                Type_Emplacement typeLocation = db.Type_Emplacement.FirstOrDefault(a => a.Libelle_Type.Equals(typeLabel.Text));
                CreateNewLocation(typeLocation);
            }
            else
            {
                panel.DoDragDrop(panel, DragDropEffects.Move);
            }
        }
        
        private void CreateNewLocation(Type_Emplacement type, int x = 30, int y = 30)
        {
            LoginTools.checkConnection();
            Emplacement newLocation = new Emplacement();
            db.Emplacement.Add(newLocation);
            newLocation.Taille_X = 10;
            newLocation.Taille_Y = 10;
            int i = locationsList.Count();
            while (db.Emplacement.Any(a => a.Nom_Emplacement.Equals("Emplacement " + i)))
            {
                i++;
            }
            foreach (GraphicLocation graphicLocation in locationsList)
            {
                if (graphicLocation.Location.Nom_Emplacement.Equals("Emplacement " + i))
                {
                    i++;
                }
            }
            newLocation.Nom_Emplacement = "Emplacement " + i;
            newLocation.Type_Emplacement = type;
            GraphicLocation newGraphicLocation = new GraphicLocation(newLocation);
            newGraphicLocation.Move(new Point(x, y), pictureBox);
            locationsList.Add(newGraphicLocation);
            SelectedLocation = newGraphicLocation;
            Refresh();
        }

        private Panel getParentTypePanel(object control)
        {
            Panel panel;
            if (control.GetType() == typeof(TableLayoutPanel))
            {
                panel = (Panel)control;
            }
            else
            {
                panel = (Panel)((Control)control).Parent;
            }
            return panel;
        }

        private void PanelType_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = getParentTypePanel(sender);
            panel.BackColor = Color.DimGray;
        }

        private void PanelType_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = getParentTypePanel(sender);
            if (!panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
            {
                panel.BackColor = Color.Gray;
            }
        }

        private void ChangeMode(MapMode mode)
        {
            mapTablePanel.Visible = false;
            importMapPanel.Visible = false;
            categoriesCheckedListBox.Visible = false;
            addLocationPanel.Visible = false;
            editLocationPanel.Visible = false;
            detailsLocationPanel.Visible = false;
            switch (mode)
            {
                case MapMode.LoadImage:
                    importMapPanel.Visible = true;
                    break;
                case MapMode.Normal:
                    mapTablePanel.Visible = true;
                    categoriesCheckedListBox.Visible = true;
                    detailsLocationPanel.Visible = true;
                    break;
                case MapMode.Edit:
                    mapTablePanel.Visible = true;
                    addLocationPanel.Visible = true;
                    editLocationPanel.Visible = true;
                    break;
                default:
                    break;
            }
        }

        private void importMapButton_Click(object sender, EventArgs e)
        {
            using (FileDialog fd = new OpenFileDialog())
            {
                fd.Title = Resources.select_background_image;
                fd.Filter = Resources.images_files_formats;
                if (fd.ShowDialog() == DialogResult.OK)
                {
                    try
                    {
                        importMapPanel.Visible = false;
                        image = new Bitmap(fd.FileName);
                        image.SetResolution(800, 600);
                        LoginTools.checkConnection();
                        App app = db.App.FirstOrDefault();
                        if (app == null)
                        {
                            app = new App();
                            db.App.Add(app);
                        }
                        MemoryStream jpegStream = new MemoryStream();
                        image.Save(jpegStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        if (image == null)
                        {
                            throw new FileLoadException();
                        }
                        app.Fond_Image = jpegStream.ToArray();
                        db.SaveChanges();
                        pictureBox.Image = image;
                        mode = MapMode.Normal;
                        ChangeMode(mode);
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show(Resources.file_not_found_please_retry);
                    }
                    catch (FileLoadException)
                    {
                        MessageBox.Show(Resources.error_when_opening_the_file_please_retry);
                    }
                }
            }
        }

        private void modeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                mode = MapMode.Edit;
            }
            else
            {
                mode = MapMode.Normal;
            }
            ChangeMode(mode);
            UpdateRightMenu();
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraphicLocation location in locationsList)
            {
                if (categoriesCheckedListBox.CheckedItems.Contains(location.Location.Type_Emplacement.Libelle_Type))
                {
                    if (SelectedLocation != null)
                    {
                        location.Draw(e, SelectedLocation.Equals(location));
                    }
                    else
                    {
                        location.Draw(e, false);
                    }
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (SelectedLocation != null)
            {
                RectangleF position = SelectedLocation.Position;
                if (mode == MapMode.Edit)
                {
                    if (!moving)
                    {
                        if (new RectangleF(position.X - 2, position.Y, 4, position.Height).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeWE;
                            cursorAction = CursorAction.ResizeW;
                        }
                        else if (new RectangleF(position.X + position.Width, position.Y, 4, position.Height).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeWE;
                            cursorAction = CursorAction.ResizeE;
                        }
                        else if (new RectangleF(position.X, position.Y - 2, position.Width, 4).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeNS;
                            cursorAction = CursorAction.ResizeN;
                        }
                        else if (new RectangleF(position.X, position.Y + position.Height, position.Width, 4).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeNS;
                            cursorAction = CursorAction.ResizeS;
                        }
                        else if (position.Contains(e.Location))
                        {
                            Cursor = Cursors.SizeAll;
                            cursorAction = CursorAction.Move;
                        }
                        else
                        {
                            Cursor = Cursors.Default;
                        }
                    }
                }
                else
                {
                    Cursor = Cursors.Default;
                }
            }
            else
            {
                Cursor = Cursors.Default;
            }
            if (moving && SelectedLocation != null)
            {
                PointF newPosition = new Point();
                bool move = false;
                switch (cursorAction)
                {
                    case CursorAction.Move:
                        {
                            PointF movePoint = new PointF
                            {
                                X = e.Location.X - offsetMoving.X,
                                Y = e.Location.Y - offsetMoving.Y
                            };
                            if (movePoint.X < 0)
                            {
                                movePoint.X = 0;
                            }
                            if (movePoint.Y < 0)
                            {
                                movePoint.Y = 0;
                            }
                            if (movePoint.X > (pictureBox.Width - SelectedLocation.Position.Width))
                            {
                                movePoint.X = pictureBox.Width - SelectedLocation.Position.Width;
                            }
                            if (movePoint.Y > (pictureBox.Height - SelectedLocation.Position.Height))
                            {
                                movePoint.Y = pictureBox.Height - SelectedLocation.Position.Height;
                            }
                            SelectedLocation.Move(movePoint, pictureBox);
                        }
                        break;
                    case CursorAction.ResizeE:
                        {
                            SizeF newSize = new SizeF
                            {
                                Height = oldSize.Height,
                                Width = oldSize.Width + (e.Location.X - startClick.X)
                            };
                            SelectedLocation.Resize(newSize, pictureBox);
                        }
                        break;
                    case CursorAction.ResizeN:
                        {
                            newPosition.Y = e.Location.Y;
                            newPosition.X = oldPosition.X;
                            SizeF newSize = new SizeF
                            {
                                Height = oldSize.Height - (e.Location.Y - startClick.Y),
                                Width = oldSize.Width
                            };
                            SelectedLocation.Resize(newSize, pictureBox);
                            move = true;
                        }
                        break;
                    case CursorAction.ResizeS:
                        {
                            SizeF newSize = new SizeF
                            {
                                Height = oldSize.Height + (e.Location.Y - startClick.Y),
                                Width = oldSize.Width
                            };
                            SelectedLocation.Resize(newSize, pictureBox);
                        }
                        break;
                    case CursorAction.ResizeW:
                        {
                            newPosition.Y = oldPosition.Y;
                            newPosition.X = e.Location.X;
                            SizeF newSize = new SizeF
                            {
                                Height = oldSize.Height,
                                Width = oldSize.Width - (e.Location.X - startClick.X)
                            };
                            SelectedLocation.Resize(newSize, pictureBox);
                            move = true;
                        }
                        break;
                    default:
                        break;
                }
                if (SelectedLocation.Location.Taille_X < 1)
                {
                    SelectedLocation.Location.Taille_X = 1;
                    move = false;
                }
                if (SelectedLocation.Location.Taille_Y < 1)
                {
                    SelectedLocation.Location.Taille_Y = 1;
                    move = false;
                }
                if (move)
                {
                    SelectedLocation.Move(newPosition, pictureBox);
                }
                pictureBox.Refresh();
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedLocation = null;
            foreach (GraphicLocation location in locationsList)
            {
                if (location.Position.Contains(e.Location))
                {
                    SelectedLocation = location;
                }
            }
            Refresh();
        }

        private void categoriesCheckedListBox_MouseUp(object sender, MouseEventArgs e)
        {
            cursorAction = CursorAction.Default;
            Refresh();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (SelectedLocation != null)
            {
                if (cursorAction != CursorAction.Default && mode == MapMode.Edit && !moving)
                {
                    moving = true;
                    startClick = e.Location;
                    oldSize = SelectedLocation.Position.Size;
                    oldPosition = SelectedLocation.Position.Location;
                    offsetMoving.X = e.Location.X - SelectedLocation.Position.X;
                    offsetMoving.Y = e.Location.Y - SelectedLocation.Position.Y;
                }
            }
        }

        private void pictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (moving)
            {
                moving = false;
            }
        }

        private void validateChangesButton_Click(object sender, EventArgs e)
        {
            LoginTools.checkConnection();
            foreach(GraphicLocation location in locationsList)
            {
                if (location.Location.Code_Emplacement == 0)
                {
                    db.Emplacement.Add(location.Location);
                }
            }
            List<int> toDelete = new List<int>();
            foreach (Emplacement location in db.Emplacement)
            {
                bool exist = locationsList.Any(graphicLocation => location.Code_Emplacement == graphicLocation.Location.Code_Emplacement);
                if (!exist)
                {
                    toDelete.Add(location.Code_Emplacement);
                }
            }
            foreach (int id in toDelete)
            {
                db.Emplacement.Remove(db.Emplacement.FirstOrDefault(a => a.Code_Emplacement == id));
            }
            try
            {
                db.SaveChanges();
            }
            catch (DbUpdateException exception)
            {
                if (exception.InnerException?.InnerException != null)
                {
                    MessageBox.Show(Resources.db_save_error + exception.InnerException.InnerException.Message);
                }
                db = new DataBase();
                FillListsControlsDromDB();
                LoadLocationsFromDb();
            }
        }

        private void UpdateRightMenu()
        {
            if (SelectedLocation == null)
            {
                return;
            }
            updatingRightMenu = true;
            LoginTools.checkConnection();
            Panel details = detailsLocationPanel;
            Panel edit = editLocationPanel;
            string resState = resStateLabel.Text;
            string buttonText = resButton.Text;
            if (SelectedLocation.Location.Type_Emplacement.Est_Reservable)
            {
                resButton.Enabled = true;
                if (
                    db.Reservation.Where(r => r.Date_Debut < dateTimePicker.Value && dateTimePicker.Value < r.Date_Fin)
                        .SelectMany(a => a.Loge)
                        .Any(l => l.Code_Emplacement == SelectedLocation.Location.Code_Emplacement))
                {
                    resStateLabel.Text = Resources.booked;
                    resButton.Text = Resources.unbook;
                }
                else
                {
                    resStateLabel.Text = Resources.free;
                    resButton.Text = Resources.book;
                }
            }
            else
            {
                resButton.Enabled = false;
                resButton.Text = Resources.book;
                resStateLabel.Text = Resources.not_bookable;
            }
            
            locationNameLabel.Text = SelectedLocation.Location.Nom_Emplacement;

            catLocationLabel.Text = SelectedLocation.Location.Type_Emplacement.Libelle_Type;
            catLocationListView.Items.Clear();

            foreach (int i in carCheckedListBox.CheckedIndices)
            {
                carCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (Caracteristique_Emplacement car in SelectedLocation.Location.Caracteristique_Emplacement)
            {
                catLocationListView.Items.Add(car.Description);
                carCheckedListBox.SetItemChecked(carCheckedListBox.Items.IndexOf(car), true);
            }

            incidentsListBox.Items.Clear();
            foreach (Incident incident in db.Incident.Where(a => a.Code_Emplacement == SelectedLocation.Location.Code_Emplacement && a.Date_Resolution == null))
            {
                incidentsListBox.Items.Add(incident);
            }

            locationNameTextBox.DataBindings.Clear();
            locationNameTextBox.DataBindings.Add("Text", SelectedLocation.Location, "Nom_Emplacement", false, DataSourceUpdateMode.OnPropertyChanged);

            typeLocationComboBox.DataBindings.Clear();
            Binding typeLocationBinding = 
                typeLocationComboBox.DataBindings.Add("SelectedItem", SelectedLocation.Location, "Type_Emplacement", true, DataSourceUpdateMode.OnPropertyChanged);
            typeLocationBinding.BindingComplete += (sender, args) => pictureBox.Refresh();

            rightPanel.Refresh();
            updatingRightMenu = false;
        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            foreach (var location in locationsList)
            {
                location.Booked = db.Reservation.Where(r => r.Date_Debut < dateTimePicker.Value && dateTimePicker.Value < r.Date_Fin)
                    .SelectMany(a => a.Loge)
                    .Any(l => l.Code_Emplacement == location.Location.Code_Emplacement);
            }
            UpdateRightMenu();
        }

        private void carCheckedListBox_Check(object sender, ItemCheckEventArgs e)
        {
            if (SelectedLocation != null && !updatingRightMenu)
            {
                Caracteristique_Emplacement item = (Caracteristique_Emplacement)carCheckedListBox.Items[e.Index];
                if (e.NewValue == CheckState.Checked)
                {
                    if (!SelectedLocation.Location.Caracteristique_Emplacement.Contains(item))
                    {
                        SelectedLocation.Location.Caracteristique_Emplacement.Add(item);
                    }
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    if (SelectedLocation.Location.Caracteristique_Emplacement.Contains(item))
                    {
                        SelectedLocation.Location.Caracteristique_Emplacement.Remove(item);
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            locationsList.Remove(SelectedLocation);
            SelectedLocation = null;
            Refresh();
        }

        private void mapTablePanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TableLayoutPanel).FullName, false))
            {
                TableLayoutPanel panel = (TableLayoutPanel)e.Data.GetData(typeof(TableLayoutPanel).FullName, false);
                panel.BackColor = Color.Gray;
                Label typeLabel = (Label)panel.Controls.Find("typeLabel", true).First();
                if (typeLabel != null)
                {
                    Type_Emplacement typeLocation = db.Type_Emplacement.FirstOrDefault(a => a.Libelle_Type.Equals(typeLabel.Text));
                    if (typeLocation != null)
                    {
                        Point controlCoordinate = pictureBox.PointToClient(new Point(e.X, e.Y));
                        Rectangle validRectangle = new Rectangle(0, 0, pictureBox.Width - 30, pictureBox.Height - 30);
                        if (validRectangle.Contains(controlCoordinate))
                        {
                            CreateNewLocation(typeLocation, controlCoordinate.X, controlCoordinate.Y);
                        }
                    }
                }
            }
        }

        private void mapTablePanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }

        private void detailsIncidentButton_Click(object sender, EventArgs e)
        {
            if (incidentsListBox.SelectedItem != null)
            {
                //TODO open new incident window
            }
        }
    }
}