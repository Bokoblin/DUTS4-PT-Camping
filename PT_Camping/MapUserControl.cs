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
        private Point offsetMoving;
        private Point startClick;
        private Size oldSize;
        private Point oldPosition;
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
            if (db.App.Where(m => m.Fond_Image != null).Count() < 1)
            {
                mode = MapMode.LOAD_IMAGE;
            }
            else
            {
                MemoryStream ms = new MemoryStream(db.App.FirstOrDefault().Fond_Image);
                Image imageJpeg;
                imageJpeg = Image.FromStream(ms);
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
            // 
            // pictureBox
            // 
            typePicture.Dock = DockStyle.Fill;
            typePicture.TabIndex = 0;
            typePicture.TabStop = false;
            if (type.Icone != null)
            {
                MemoryStream ms = new MemoryStream(db.App.FirstOrDefault().Fond_Image);
                typePicture.Image = new Bitmap(ms);
                ms.Close();
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

        private void TypePanel_Click(object sender, EventArgs e)
        {
            Panel panel = (Panel)sender;
            Label typeLabel = (Label)panel.Controls.Find("typeLabel", true).First();
            LoginTools.checkConnection();
            Emplacement newLocation = new Emplacement();
            db.Emplacement.Add(newLocation);
            newLocation.Cordonnee_X = 10;
            newLocation.Coordonnee_Y = 10;
            newLocation.Taille_X = 10;
            newLocation.Taille_Y = 10;
            int i = locationsList.Count();
            while (db.Emplacement.Where(a => a.Nom_Emplacement.Equals("Emplacement " + i)).Count() > 0)
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
            newLocation.Type_Emplacement = db.Type_Emplacement.First(a => a.Libelle_Type == typeLabel.Text);
            GraphicLocation newGraphicLocation = new GraphicLocation(newLocation);
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
                fd.Title = "Sélectionnez une image de fond";
                fd.Filter = "Image Files |*.png; *.jpg; *.bmp";
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
                        app.Fond_Image = jpegStream.ToArray();
                        db.SaveChanges();
                        if (image == null)
                        {
                            throw new FileLoadException();
                        }
                        pictureBox.Image = image;
                        mode = MapMode.NORMAL;
                        changeMode(mode);
                    }
                    catch (FileNotFoundException)
                    {
                        MessageBox.Show("Fichier non trouvé ! Veuillez réessayer.");
                    }
                    catch (FileLoadException)
                    {
                        MessageBox.Show("Erreur lors de l'ouverture du fichier, veuillez réessayer.");
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
                Rectangle position = selectedLocation.Position;
                if (mode == MapMode.EDIT)
                {
                    if (!moving)
                    {
                        if (new Rectangle(position.X - 2, position.Y, 4, position.Height).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeWE;
                            cursorAction = CursorAction.RESIZE_W;
                        }
                        else if (new Rectangle(position.X + position.Width, position.Y, 4, position.Height).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeWE;
                            cursorAction = CursorAction.RESIZE_E;
                        }
                        else if (new Rectangle(position.X, position.Y - 2, position.Width, 4).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeNS;
                            cursorAction = CursorAction.RESIZE_N;
                        }
                        else if (new Rectangle(position.X, position.Y + position.Height, position.Width, 4).Contains(e.Location))
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
                switch (cursorAction)
                {
                    case CursorAction.MOVE:
                        {
                            Point movePoint = new Point();
                            movePoint.X = e.Location.X - offsetMoving.X;
                            movePoint.Y = e.Location.Y - offsetMoving.Y;
                            selectedLocation.move(movePoint, pictureBox);
                        }
                        break;
                    case CursorAction.RESIZE_E:
                        {
                            Size newSize = new Size();
                            newSize.Height = oldSize.Height;
                            newSize.Width = oldSize.Width + (e.Location.X - startClick.X);
                            selectedLocation.resize(newSize, pictureBox);
                        }
                        break;
                    case CursorAction.RESIZE_N:
                        {
                            Point newPosition = new Point();
                            newPosition.Y = e.Location.Y;
                            newPosition.X = oldPosition.X;
                            Size newSize = new Size();
                            newSize.Height = oldSize.Height - (e.Location.Y - startClick.Y);
                            newSize.Width = oldSize.Width;
                            selectedLocation.resize(newSize, pictureBox);
                            selectedLocation.move(newPosition, pictureBox);
                        }
                        break;
                    case CursorAction.RESIZE_S:
                        {
                            Size newSize = new Size();
                            newSize.Height = oldSize.Height + (e.Location.Y - startClick.Y);
                            newSize.Width = oldSize.Width;
                            selectedLocation.resize(newSize, pictureBox);
                        }
                        break;
                    case CursorAction.RESIZE_W:
                        {
                            Point newPosition = new Point();
                            newPosition.Y = oldPosition.Y;
                            newPosition.X = e.Location.X;
                            Size newSize = new Size();
                            newSize.Height = oldSize.Height;
                            newSize.Width = oldSize.Width - (e.Location.X - startClick.X);
                            selectedLocation.resize(newSize, pictureBox);
                            selectedLocation.move(newPosition, pictureBox);
                        }
                        break;
                    default:
                        break;
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
            if (db.Reservation.Where(r => r.Date_Debut < dateTimePicker.Value && dateTimePicker.Value < r.Date_Fin).SelectMany(a => a.Loge).Where(l => l.Code_Emplacement == selectedLocation.Location.Code_Emplacement).Count() >= 1)
            {
                resStateLabel.Text = "Reservé";
                resButton.Text = "Libérer";
            }
            else
            {
                resStateLabel.Text = "Libre";
                resButton.Text = "Réserver";
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
    }
}