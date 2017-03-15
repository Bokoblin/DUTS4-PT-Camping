using System;
using System.Collections.Generic;
using System.ComponentModel;
using System.Drawing;
using System.Data;
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
        LOAD_IMAGE,
        NORMAL,
        EDIT
    };

    public enum CursorAction
    {
        DEFAULT,
        MOVE,
        RESIZE_N,
        RESIZE_E,
        RESIZE_S,
        RESIZE_W
    };

    public partial class MapUserControl : UserControl
    {
        private HomeUserControl mHomeUserControl;
        private DataBase db;
        private Bitmap image;
        private MapMode mode;
        private List<GraphicLocation> locationsList;
        private GraphicLocation _selectedLocation;
        private GraphicLocation selectedLocation
        {
            set
            {
                _selectedLocation = value;
                if (_selectedLocation != null)
                {
                    updateRightMenu();
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

        public MapUserControl(HomeUserControl homeUserControl)
        {
            InitializeComponent();
            cursorAction = CursorAction.DEFAULT;
            moving = false;
            offsetMoving = new Point();
            mHomeUserControl = homeUserControl;
            Dock = DockStyle.Fill;
            LoginTools.checkConnection();
            db = new DataBase();
            foreach (Caracteristique_Emplacement car in db.Caracteristique_Emplacement)
            {
                carCheckedListBox.Items.Add(car);
            }
            carCheckedListBox.DisplayMember = "Description";
            locationsList = new List<GraphicLocation>();
            foreach (Emplacement loc in db.Emplacement)
            {
                locationsList.Add(new GraphicLocation(loc));
            }
            List<Type_Emplacement> typesLocations = db.Type_Emplacement.ToList();
            int i = 0;
            foreach (Type_Emplacement type in typesLocations)
            {
                typeLocationComboBox.Items.Add(type);

                TableLayoutPanel panelType = createInsertLocationButton(type);
                addLocationPanel.Controls.Add(panelType);
                i++;

                categoriesCheckedListBox.Items.Add(type.Libelle_Type, true);
            }
            typeLocationComboBox.DisplayMember = "Libelle_Type";
            typeLocationComboBox.ValueMember = "Code_Type";
            if (!db.App.Any(m => m.Fond_Image != null))
            {
                mode = MapMode.LOAD_IMAGE;
            }
            else
            {
                MemoryStream ms = new MemoryStream(db.App.FirstOrDefault().Fond_Image);
                var imageJpeg = Image.FromStream(ms);
                image = new Bitmap(imageJpeg);
                ms.Close();
                pictureBox.Image = image;
                mode = MapMode.NORMAL;
            }
            changeMode(mode);
        }

        private TableLayoutPanel createInsertLocationButton(Type_Emplacement type)
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
            typePanel.Click += TypePanel_Click;
            typePanel.MouseDown += TypePanel_MouseDown;
            typePanel.DragLeave += TypePanel_DragLeave;
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
            ((Panel)sender).DoDragDrop(sender, DragDropEffects.Move);
        }

        private void TypePanel_DragLeave(object sender, EventArgs e)
        {
            throw new NotImplementedException();
        }

        private void TypePanel_Click(object sender, EventArgs e)
        {
            LoginTools.checkConnection();
            Panel panel = (Panel)sender;
            Label typeLabel = (Label)panel.Controls.Find("typeLabel", true).First();
            Type_Emplacement typeLocation = db.Type_Emplacement.FirstOrDefault(a => a.Libelle_Type.Equals(typeLabel.Text));
            createNewLocation(typeLocation);
        }

        private void createNewLocation(Type_Emplacement type, int x = 30, int y = 30)
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
            newGraphicLocation.move(new Point(x, y), pictureBox);
            locationsList.Add(newGraphicLocation);
            selectedLocation = newGraphicLocation;
            Refresh();
        }

        private void PanelType_MouseEnter(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            panel.BackColor = Color.DimGray;
        }

        private void PanelType_MouseLeave(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            if (!panel.ClientRectangle.Contains(panel.PointToClient(Cursor.Position)))
            {
                panel.BackColor = Color.Gray;
            }
        }

        private void changeMode(MapMode mode)
        {
            mapTablePanel.Visible = false;
            importMapPanel.Visible = false;
            categoriesCheckedListBox.Visible = false;
            addLocationPanel.Visible = false;
            editLocationPanel.Visible = false;
            detailsLocationPanel.Visible = false;
            switch (mode)
            {
                case MapMode.LOAD_IMAGE:
                    importMapPanel.Visible = true;
                    break;
                case MapMode.NORMAL:
                    mapTablePanel.Visible = true;
                    categoriesCheckedListBox.Visible = true;
                    detailsLocationPanel.Visible = true;
                    break;
                case MapMode.EDIT:
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
                        mode = MapMode.NORMAL;
                        changeMode(mode);
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
                mode = MapMode.EDIT;
            }
            else
            {
                mode = MapMode.NORMAL;
            }
            changeMode(mode);
        }

        private void pictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraphicLocation location in locationsList)
            {
                if (categoriesCheckedListBox.CheckedItems.Contains(location.Location.Type_Emplacement.Libelle_Type))
                {
                    if (selectedLocation != null)
                    {
                        location.draw(e, selectedLocation.Equals(location));
                    }
                    else
                    {
                        location.draw(e, false);
                    }
                }
            }
        }

        private void pictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (selectedLocation != null)
            {
                RectangleF position = selectedLocation.Position;
                if (mode == MapMode.EDIT)
                {
                    if (!moving)
                    {
                        if (new RectangleF(position.X - 2, position.Y, 4, position.Height).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeWE;
                            cursorAction = CursorAction.RESIZE_W;
                        }
                        else if (new RectangleF(position.X + position.Width, position.Y, 4, position.Height).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeWE;
                            cursorAction = CursorAction.RESIZE_E;
                        }
                        else if (new RectangleF(position.X, position.Y - 2, position.Width, 4).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeNS;
                            cursorAction = CursorAction.RESIZE_N;
                        }
                        else if (new RectangleF(position.X, position.Y + position.Height, position.Width, 4).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeNS;
                            cursorAction = CursorAction.RESIZE_S;
                        }
                        else if (position.Contains(e.Location))
                        {
                            Cursor = Cursors.SizeAll;
                            cursorAction = CursorAction.MOVE;
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
            if (moving && selectedLocation != null)
            {
                PointF newPosition = new Point();
                bool move = false;
                switch (cursorAction)
                {
                    case CursorAction.MOVE:
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
                            if (movePoint.X > (pictureBox.Width - selectedLocation.Position.Width))
                            {
                                movePoint.X = pictureBox.Width - selectedLocation.Position.Width;
                            }
                            if (movePoint.Y > (pictureBox.Height - selectedLocation.Position.Height))
                            {
                                movePoint.Y = pictureBox.Height - selectedLocation.Position.Height;
                            }
                            selectedLocation.move(movePoint, pictureBox);
                        }
                        break;
                    case CursorAction.RESIZE_E:
                        {
                            SizeF newSize = new SizeF
                            {
                                Height = oldSize.Height,
                                Width = oldSize.Width + (e.Location.X - startClick.X)
                            };
                            selectedLocation.resize(newSize, pictureBox);
                        }
                        break;
                    case CursorAction.RESIZE_N:
                        {
                            newPosition.Y = e.Location.Y;
                            newPosition.X = oldPosition.X;
                            SizeF newSize = new SizeF
                            {
                                Height = oldSize.Height - (e.Location.Y - startClick.Y),
                                Width = oldSize.Width
                            };
                            selectedLocation.resize(newSize, pictureBox);
                            move = true;
                        }
                        break;
                    case CursorAction.RESIZE_S:
                        {
                            SizeF newSize = new SizeF
                            {
                                Height = oldSize.Height + (e.Location.Y - startClick.Y),
                                Width = oldSize.Width
                            };
                            selectedLocation.resize(newSize, pictureBox);
                        }
                        break;
                    case CursorAction.RESIZE_W:
                        {
                            newPosition.Y = oldPosition.Y;
                            newPosition.X = e.Location.X;
                            SizeF newSize = new SizeF
                            {
                                Height = oldSize.Height,
                                Width = oldSize.Width - (e.Location.X - startClick.X)
                            };
                            selectedLocation.resize(newSize, pictureBox);
                            move = true;
                        }
                        break;
                    default:
                        break;
                }
                if (selectedLocation.Location.Taille_X < 1)
                {
                    selectedLocation.Location.Taille_X = 1;
                    move = false;
                }
                if (selectedLocation.Location.Taille_Y < 1)
                {
                    selectedLocation.Location.Taille_Y = 1;
                    move = false;
                }
                if (move)
                {
                    selectedLocation.move(newPosition, pictureBox);
                }
                pictureBox.Refresh();
            }
        }

        private void pictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            bool selected = false;
            foreach (GraphicLocation location in locationsList)
            {
                if (location.Position.Contains(e.Location))
                {
                    selectedLocation = location;
                    selected = true;
                    break;
                }
            }
            if (!selected)
            {
                selectedLocation = null;
            }
            Refresh();
        }

        private void categoriesCheckedListBox_MouseUp(object sender, MouseEventArgs e)
        {
            cursorAction = CursorAction.DEFAULT;
            Refresh();
        }

        private void pictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (selectedLocation != null)
            {
                if (cursorAction != CursorAction.DEFAULT && mode == MapMode.EDIT && !moving)
                {
                    moving = true;
                    startClick = e.Location;
                    oldSize = selectedLocation.Position.Size;
                    oldPosition = selectedLocation.Position.Location;
                    offsetMoving.X = e.Location.X - selectedLocation.Position.X;
                    offsetMoving.Y = e.Location.Y - selectedLocation.Position.Y;
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
                bool exist = false;
                foreach (GraphicLocation graphicLocation in locationsList)
                {
                    if (location.Code_Emplacement == graphicLocation.Location.Code_Emplacement)
                    {
                        exist = true;
                        break;
                    }
                }
                if (!exist)
                {
                    toDelete.Add(location.Code_Emplacement);
                }
            }
            foreach (int id in toDelete)
            {
                db.Emplacement.Remove(db.Emplacement.FirstOrDefault(a => a.Code_Emplacement == id));
            }
            db.SaveChanges();
        }

        private void updateRightMenu()
        {
            LoginTools.checkConnection();
            Panel details = detailsLocationPanel;
            Panel edit = editLocationPanel;
            string resState = resStateLabel.Text;
            string buttonText = resButton.Text;
            if (selectedLocation.Location.Type_Emplacement.Est_Reservable)
            {
                resButton.Enabled = true;
                if (
                    db.Reservation.Where(r => r.Date_Debut < dateTimePicker.Value && dateTimePicker.Value < r.Date_Fin)
                        .SelectMany(a => a.Loge)
                        .Any(l => l.Code_Emplacement == selectedLocation.Location.Code_Emplacement))
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
            
            locationNameLabel.Text = selectedLocation.Location.Nom_Emplacement;
            catLocationLabel.Text = selectedLocation.Location.Type_Emplacement.Libelle_Type;
            catLocationListView.Items.Clear();

            foreach (int i in carCheckedListBox.CheckedIndices)
            {
                carCheckedListBox.SetItemCheckState(i, CheckState.Unchecked);
            }

            foreach (Caracteristique_Emplacement car in selectedLocation.Location.Caracteristique_Emplacement)
            {
                catLocationListView.Items.Add(car.Description);
                carCheckedListBox.SetItemChecked(carCheckedListBox.Items.IndexOf(car), true);
            }

            locationNameTextBox.DataBindings.Clear();
            locationNameTextBox.DataBindings.Add("Text", selectedLocation.Location, "Nom_Emplacement", false, DataSourceUpdateMode.OnPropertyChanged);

            typeLocationComboBox.DataBindings.Clear();
            typeLocationComboBox.DataBindings.Add("SelectedItem", selectedLocation.Location, "Type_Emplacement", false, DataSourceUpdateMode.OnPropertyChanged);

        }

        private void dateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            foreach (var location in locationsList)
            {
                location.Booked = db.Reservation.Where(r => r.Date_Debut < dateTimePicker.Value && dateTimePicker.Value < r.Date_Fin)
                    .SelectMany(a => a.Loge)
                    .Any(l => l.Code_Emplacement == location.Location.Code_Emplacement);
            }
            updateRightMenu();
        }

        private void carCheckedListBox_Check(object sender, ItemCheckEventArgs e)
        {
            if (selectedLocation != null)
            {
                Caracteristique_Emplacement item = (Caracteristique_Emplacement)carCheckedListBox.Items[e.Index];
                if (e.NewValue == CheckState.Checked)
                {
                    if (!selectedLocation.Location.Caracteristique_Emplacement.Contains(item))
                    {
                        selectedLocation.Location.Caracteristique_Emplacement.Add(item);
                    }
                }
                else if (e.NewValue == CheckState.Unchecked)
                {
                    if (selectedLocation.Location.Caracteristique_Emplacement.Contains(item))
                    {
                        selectedLocation.Location.Caracteristique_Emplacement.Remove(item);
                    }
                }
            }
        }

        private void deleteButton_Click(object sender, EventArgs e)
        {
            locationsList.Remove(selectedLocation);
            selectedLocation = null;
            Refresh();
        }

        private void mapTablePanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TableLayoutPanel).FullName, false))
            {
                Type_Emplacement typeLocation;
                TableLayoutPanel panel = (TableLayoutPanel)e.Data.GetData(typeof(TableLayoutPanel).FullName, false);
                Label typeLabel = (Label)panel.Controls.Find("typeLabel", true).First();
                if (typeLabel != null)
                {
                    typeLocation = db.Type_Emplacement.FirstOrDefault(a => a.Libelle_Type.Equals(typeLabel.Text));
                    if (typeLocation != null)
                    {
                        Point controlCoordinate = pictureBox.PointToClient(new Point(e.X, e.Y));
                        Rectangle validRectangle = new Rectangle(0, 0, pictureBox.Width - 30, pictureBox.Height - 30);
                        if (validRectangle.Contains(controlCoordinate))
                        {
                            createNewLocation(typeLocation, controlCoordinate.X, controlCoordinate.Y);
                        }
                    }
                }
            }
        }

        private void mapTablePanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }
    }
}