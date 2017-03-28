using PT_Camping.Model;
using PT_Camping.Properties;
using System;
using System.Collections.Generic;
using System.Data.Entity.Infrastructure;
using System.Drawing;
using System.IO;
using System.Linq;
using System.Windows.Forms;
using PT_Camping.Views.Forms;

namespace PT_Camping.Views.UserControls
{
    public enum MapMode
    {
        LoadImage,
        Normal,
        Edit,
        PickLocation
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

    /// <summary>
    /// The MapUserControl is a UserControl handling the campground's map.
    /// It allows visualizing the map with the infrastrures,
    /// adding, removing, modifying a camping accommodation.
    /// 
    /// </summary>
    /// Authors : Arthur, Alexandre
    /// Since : 09/02/17
    /// 
    public partial class MapUserControl : UserControl
    {
        private DataBase _db;
        private Bitmap _image;
        private MapMode _mode;
        private List<GraphicLocation> _locationsList;
        private GraphicLocation _selectedLocation;
        private bool _moving;
        private PointF _offsetMoving;
        private PointF _startClick;
        private SizeF _oldSize;
        private PointF _oldPosition;
        private CursorAction _cursorAction;
        private bool _updatingRightMenu;
        private NewReservation.LocationSelectedDelegate _pickCallBackAction;

        private GraphicLocation SelectedLocation
        {
            set
            {
                _selectedLocation = value;
                if (_mode == MapMode.PickLocation && value != null)
                {
                    if (!value.Location.Type_Emplacement.Est_Reservable)
                    {
                        MessageBox.Show(Resources.not_reservable_emplacement);
                    }
                    else
                    {
                        HomeUserControl.HomeTabControl.SelectTab(0);
                        _pickCallBackAction(value.Location.Code_Emplacement);
                    }
                }
                else
                {
                    UpdateRightMenu();
                }
            }
            get
            {
                return _selectedLocation;
            }
        }
        public HomeUserControl HomeUserControl { get; set; }

        public MapUserControl(HomeUserControl home)
        {
            InitializeComponent();
            LoginTools.CheckConnection();
            HomeUserControl = home;
            _db = new DataBase();

            _cursorAction = CursorAction.Default;
            _moving = false;
            _offsetMoving = new Point();

            FillListsControlsDromDb();

            LoadLocationsFromDb();

            if (!_db.App.Any(m => m.Fond_Image != null))
            {
                _mode = MapMode.LoadImage;
            }
            else
            {
                MemoryStream ms = new MemoryStream(_db.App.FirstOrDefault().Fond_Image);
                var imageJpeg = Image.FromStream(ms);
                _image = new Bitmap(imageJpeg);
                ms.Close();
                pictureBox.Image = _image;
                _mode = MapMode.Normal;
            }
            ChangeMode(_mode);    
        }


        public MapUserControl(HomeUserControl home, int locationCode) : this(home)
        {
            SelectFromStats(locationCode);
        }

        public void StartPickLocation(NewReservation.LocationSelectedDelegate pickLocationSelectedDelegate, DateTime date)
        {
            _mode = MapMode.PickLocation;
            dateTimePicker.Value = date;
            _pickCallBackAction = pickLocationSelectedDelegate;
            ChangeMode(_mode);
        }

        public void ResetMode()
        {
            if (!_db.App.Any(m => m.Fond_Image != null))
            {
                _mode = MapMode.LoadImage;
            }
            else
            {
                _mode = MapMode.Normal;
            }
            ChangeMode(_mode);
        }

        public void SelectFromStats(int locationCode)
        {
            foreach (var location in _locationsList)
            {
                if (location.Location.Code_Emplacement == locationCode)
                {
                    SelectedLocation = location;
                    break;
                }
            }
            _mode = MapMode.Normal;
            ChangeMode(_mode);
        }

        internal void HandleResize(Size mapTabSize)
        {
            Size = mapTabSize;
        }

        private void LoadLocationsFromDb()
        {
            LoginTools.CheckConnection();
            _locationsList = new List<GraphicLocation>();
            foreach (Emplacement loc in _db.Emplacement)
            {
                _locationsList.Add(new GraphicLocation(loc));
            }
            SelectedLocation = null;
            pictureBox.Refresh();
        }


        private void FillListsControlsDromDb()
        {
            carCheckedListBox.Items.Clear();
            foreach (Caracteristique_Emplacement car in _db.Caracteristique_Emplacement)
            {
                carCheckedListBox.Items.Add(car);
            }
            carCheckedListBox.DisplayMember = "Description";

            addLocationPanel.Controls.Clear();
            typeLocationComboBox.Items.Clear();
            categoriesCheckedListBox.Items.Clear();
            var typesLocations = _db.Type_Emplacement.ToList();

            foreach (Type_Emplacement type in typesLocations)
            {
                typeLocationComboBox.Items.Add(type);

                TableLayoutPanel panelType = CreateInsertLocationButton(type);
                addLocationPanel.Controls.Add(panelType);

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
                            _image = new Bitmap(fd.FileName);
                            if (_image == null)
                            {
                                throw new FileLoadException();
                            }
                            _image.SetResolution(50, 50);
                            ImageConverter converter = new ImageConverter();
                            type.Icone = (byte[])converter.ConvertTo(_image, typeof(byte[]));
                            _db.SaveChanges();
                            typePicture.Image = _image;
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
                LoginTools.CheckConnection();
                Label typeLabel = (Label) panel.Controls.Find("typeLabel", true).First();
                Type_Emplacement typeLocation = _db.Type_Emplacement.FirstOrDefault(a => a.Libelle_Type.Equals(typeLabel.Text));
                CreateNewLocation(typeLocation);
            }
            else
            {
                panel.DoDragDrop(panel, DragDropEffects.Move);
            }
        }
        

        private void CreateNewLocation(Type_Emplacement type, int x = 30, int y = 30)
        {
            LoginTools.CheckConnection();
            Emplacement newLocation = new Emplacement();
            _db.Emplacement.Add(newLocation);
            newLocation.Taille_X = 10;
            newLocation.Taille_Y = 10;
            int i = _locationsList.Count;
            while (_db.Emplacement.Any(a => a.Nom_Emplacement.Equals("Emplacement " + i)))
            {
                i++;
            }
            foreach (GraphicLocation graphicLocation in _locationsList)
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
            _locationsList.Add(newGraphicLocation);
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
            importMapPanel.Visible = false;
            categoriesCheckedListBox.Visible = false;
            addLocationPanel.Visible = false;
            editLocationPanel.Visible = false;
            detailsLocationPanel.Visible = false;
            modeCheckBox.Visible = true;
            mapTablePanel.Visible = true;
            mapTablePanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 60F);
            mapTablePanel.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 25F);
            switch (mode)
            {
                case MapMode.LoadImage:
                    mapTablePanel.Visible = false;
                    importMapPanel.Visible = true;
                    break;
                case MapMode.Normal:
                    categoriesCheckedListBox.Visible = true;
                    detailsLocationPanel.Visible = true;
                    break;
                case MapMode.Edit:
                    addLocationPanel.Visible = true;
                    editLocationPanel.Visible = true;
                    break;
                case MapMode.PickLocation:
                    modeCheckBox.Visible = false;
                    categoriesCheckedListBox.Visible = true;
                    mapTablePanel.ColumnStyles[1] = new ColumnStyle(SizeType.Percent, 85F);
                    mapTablePanel.ColumnStyles[2] = new ColumnStyle(SizeType.Percent, 0F);
                    break;
                default:
                    throw new ArgumentOutOfRangeException(nameof(mode), mode, null);
            }
            InitPermissions();
        }

        public void InitPermissions()
        {
            var userRights = _db.Personne.First(a => a.Code_Personne == LoginTools.Employee.Code_Personne).Droit.ToList();
            importMapButton.Enabled = userRights.Any(d => d.Libelle_Droit == "writeMap");
            modeCheckBox.Visible = userRights.Any(d => d.Libelle_Droit == "writeMap");
            validateChangesButton.Visible = userRights.Any(d => d.Libelle_Droit == "writeMap");
            importMapRightPanel.Enabled = modeCheckBox.Checked;
        }


        private void ImportMapButton_Click(object sender, EventArgs e)
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
                        _image = new Bitmap(fd.FileName);
                        _image.SetResolution(800, 600);
                        LoginTools.CheckConnection();
                        App app = _db.App.FirstOrDefault();
                        if (app == null)
                        {
                            app = new App();
                            _db.App.Add(app);
                        }
                        MemoryStream jpegStream = new MemoryStream();
                        _image.Save(jpegStream, System.Drawing.Imaging.ImageFormat.Jpeg);
                        if (_image == null)
                        {
                            throw new FileLoadException();
                        }
                        app.Fond_Image = jpegStream.ToArray();
                        _db.SaveChanges();
                        pictureBox.Image = _image;
                        _mode = MapMode.Normal;
                        ChangeMode(_mode);
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


        private void ModeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            _mode = ((CheckBox)sender).Checked ? MapMode.Edit : MapMode.Normal;
            ChangeMode(_mode);
            UpdateRightMenu();
        }


        private void PictureBox_Paint(object sender, PaintEventArgs e)
        {
            foreach (GraphicLocation location in _locationsList)
            {
                if (categoriesCheckedListBox.CheckedItems.Contains(location.Location.Type_Emplacement.Libelle_Type))
                {
                    location.Draw(e, SelectedLocation != null && SelectedLocation.Equals(location), pictureBox);
                }
            }
        }


        private void PictureBox_MouseMove(object sender, MouseEventArgs e)
        {
            if (SelectedLocation != null)
            {
                RectangleF position = SelectedLocation.Position;
                if (_mode == MapMode.Edit)
                {
                    if (!_moving)
                    {
                        if (new RectangleF(position.X - 2, position.Y, 4, position.Height).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeWE;
                            _cursorAction = CursorAction.ResizeW;
                        }
                        else if (new RectangleF(position.X + position.Width, position.Y, 4, position.Height).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeWE;
                            _cursorAction = CursorAction.ResizeE;
                        }
                        else if (new RectangleF(position.X, position.Y - 2, position.Width, 4).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeNS;
                            _cursorAction = CursorAction.ResizeN;
                        }
                        else if (new RectangleF(position.X, position.Y + position.Height, position.Width, 4).Contains(e.Location))
                        {
                            Cursor = Cursors.SizeNS;
                            _cursorAction = CursorAction.ResizeS;
                        }
                        else if (position.Contains(e.Location))
                        {
                            Cursor = Cursors.SizeAll;
                            _cursorAction = CursorAction.Move;
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
            if (_moving && SelectedLocation != null)
            {
                PointF newPosition = new Point();
                bool move = false;
                switch (_cursorAction)
                {
                    case CursorAction.Move:
                        {
                            PointF movePoint = new PointF
                            {
                                X = e.Location.X - _offsetMoving.X,
                                Y = e.Location.Y - _offsetMoving.Y
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
                                Height = _oldSize.Height,
                                Width = _oldSize.Width + (e.Location.X - _startClick.X)
                            };
                            SelectedLocation.Resize(newSize, pictureBox);
                        }
                        break;
                    case CursorAction.ResizeN:
                        {
                            newPosition.Y = e.Location.Y;
                            newPosition.X = _oldPosition.X;
                            SizeF newSize = new SizeF
                            {
                                Height = _oldSize.Height - (e.Location.Y - _startClick.Y),
                                Width = _oldSize.Width
                            };
                            SelectedLocation.Resize(newSize, pictureBox);
                            move = true;
                        }
                        break;
                    case CursorAction.ResizeS:
                        {
                            SizeF newSize = new SizeF
                            {
                                Height = _oldSize.Height + (e.Location.Y - _startClick.Y),
                                Width = _oldSize.Width
                            };
                            SelectedLocation.Resize(newSize, pictureBox);
                        }
                        break;
                    case CursorAction.ResizeW:
                        {
                            newPosition.Y = _oldPosition.Y;
                            newPosition.X = e.Location.X;
                            SizeF newSize = new SizeF
                            {
                                Height = _oldSize.Height,
                                Width = _oldSize.Width - (e.Location.X - _startClick.X)
                            };
                            SelectedLocation.Resize(newSize, pictureBox);
                            move = true;
                        }
                        break;
                    case CursorAction.Default:
                        break;
                    default:
                        throw new ArgumentOutOfRangeException();
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


        private void PictureBox_MouseClick(object sender, MouseEventArgs e)
        {
            SelectedLocation = null;
            foreach (GraphicLocation location in _locationsList)
            {
                if (location.Position.Contains(e.Location))
                {
                    SelectedLocation = location;
                }
            }
            Refresh();
        }


        private void CategoriesCheckedListBox_MouseUp(object sender, MouseEventArgs e)
        {
            _cursorAction = CursorAction.Default;
            Refresh();
        }


        private void PictureBox_MouseDown(object sender, MouseEventArgs e)
        {
            if (SelectedLocation != null)
            {
                if (_cursorAction != CursorAction.Default && _mode == MapMode.Edit && !_moving)
                {
                    _moving = true;
                    _startClick = e.Location;
                    _oldSize = SelectedLocation.Position.Size;
                    _oldPosition = SelectedLocation.Position.Location;
                    _offsetMoving.X = e.Location.X - SelectedLocation.Position.X;
                    _offsetMoving.Y = e.Location.Y - SelectedLocation.Position.Y;
                }
            }
        }


        private void PictureBox_MouseUp(object sender, MouseEventArgs e)
        {
            if (_moving)
            {
                _moving = false;
            }
        }


        private void ValidateChangesButton_Click(object sender, EventArgs e)
        {
            Cursor.Current = Cursors.WaitCursor;
            LoginTools.CheckConnection();

            foreach(GraphicLocation location in _locationsList)
            {
                if (location.Location.Code_Emplacement == 0)
                {
                    _db.Emplacement.Add(location.Location);
                }
            }
            var toDelete = new List<int>();
            foreach (Emplacement location in _db.Emplacement)
            {
                bool exist = _locationsList.Any(graphicLocation => location.Code_Emplacement 
                                                == graphicLocation.Location.Code_Emplacement);
                if (!exist)
                {
                    toDelete.Add(location.Code_Emplacement);
                }
            }

            foreach (int id in toDelete)
            {
                foreach (Incident incident in _db.Incident.Where(a => a.Code_Emplacement == id))
                {
                    _db.Incident.Remove(incident);
                }
                foreach (Loge loge in _db.Loge.Where(a => a.Code_Emplacement == id))
                {
                    _db.Loge.Remove(loge);
                }
                _db.Emplacement.Remove(_db.Emplacement.FirstOrDefault(a => a.Code_Emplacement == id));
            }
            try
            {
                _db.SaveChanges();
                Cursor.Current = Cursors.Default;
            }
            catch (DbUpdateException exception)
            {
                if (exception.InnerException?.InnerException != null)
                {
                    Cursor.Current = Cursors.Default;
                    MessageBox.Show(Resources.db_save_error + exception.InnerException.InnerException.Message);
                }
                _db = new DataBase();
                FillListsControlsDromDb();
                LoadLocationsFromDb();
            }
        }


        private void UpdateRightMenu()
        {
            if (SelectedLocation == null)
            {
                nullSelectionPanel.Visible = true;
                nullSelectionPanel.BringToFront();
                return;
            }
            nullSelectionPanel.Visible = false;
            _updatingRightMenu = true;
            LoginTools.CheckConnection();
            if (SelectedLocation.Location.Type_Emplacement.Est_Reservable)
            {
                reserveButton.Enabled = true;
                if (
                    _db.Reservation.Where(r => r.Date_Debut < dateTimePicker.Value && dateTimePicker.Value < r.Date_Fin)
                        .SelectMany(a => a.Loge)
                        .Any(l => l.Code_Emplacement == SelectedLocation.Location.Code_Emplacement))
                {
                    resStateLabel.Text = Resources.booked;
                    reserveButton.Text = Resources.unbook;
                }
                else
                {
                    resStateLabel.Text = Resources.free;
                    reserveButton.Text = Resources.book;
                }
            }
            else
            {
                reserveButton.Enabled = false;
                reserveButton.Text = Resources.book;
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

            locationIssuesListBox.Items.Clear();
            foreach (var issue in _db.Incident.Where(
                a => a.Code_Emplacement == SelectedLocation.Location.Code_Emplacement 
                && a.Date_Resolution == null))
            {
                var item = new ListViewItem(new[] { issue.Type_Incident.Type_Incident1 })
                {
                    Name = issue.Code_Incident.ToString()
                };
                locationIssuesListBox.Items.Add(item);
            }


            locationNameTextBox.DataBindings.Clear();
            locationNameTextBox.DataBindings.Add("Text", SelectedLocation.Location, "Nom_Emplacement", false, DataSourceUpdateMode.OnPropertyChanged);

            typeLocationComboBox.DataBindings.Clear();
            Binding typeLocationBinding = 
                typeLocationComboBox.DataBindings.Add("SelectedItem", SelectedLocation.Location, "Type_Emplacement", true, DataSourceUpdateMode.OnPropertyChanged);
            typeLocationBinding.BindingComplete += (sender, args) => pictureBox.Refresh();

            rightPanel.Refresh();
            _updatingRightMenu = false;
        }


        private void DateTimePicker_ValueChanged(object sender, EventArgs e)
        {
            foreach (var location in _locationsList)
            {
                location.Booked = _db.Reservation.Where(r => r.Date_Debut < dateTimePicker.Value && dateTimePicker.Value < r.Date_Fin)
                    .SelectMany(a => a.Loge)
                    .Any(l => l.Code_Emplacement == location.Location.Code_Emplacement);
            }
            UpdateRightMenu();
        }


        private void CarCheckedListBox_Check(object sender, ItemCheckEventArgs e)
        {
            if (SelectedLocation != null && !_updatingRightMenu)
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


        private void DeleteButton_Click(object sender, EventArgs e)
        {
            _locationsList.Remove(SelectedLocation);
            SelectedLocation = null;
            Refresh();
        }


        private void MapTablePanel_DragDrop(object sender, DragEventArgs e)
        {
            if (e.Data.GetDataPresent(typeof(TableLayoutPanel).FullName, false))
            {
                TableLayoutPanel panel = (TableLayoutPanel)e.Data.GetData(typeof(TableLayoutPanel).FullName, false);
                panel.BackColor = Color.Gray;
                Label typeLabel = (Label)panel.Controls.Find("typeLabel", true).First();
                if (typeLabel != null)
                {
                    Type_Emplacement typeLocation = _db.Type_Emplacement.FirstOrDefault(a => a.Libelle_Type.Equals(typeLabel.Text));
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


        private void MapTablePanel_DragEnter(object sender, DragEventArgs e)
        {
            e.Effect = DragDropEffects.Move;
        }


        private void LocationIssuesListBox_DoubleClick(object sender, EventArgs e)
        {
            var userRights = _db.Personne.First(a => a.Code_Personne == LoginTools.Employee.Code_Personne).Droit.ToList();
            if(userRights.Any(d => d.Libelle_Droit == "readIssues") )
            {
                if (locationIssuesListBox.SelectedItems.Count > 0)
                {
                    var code = int.Parse(locationIssuesListBox.SelectedItems[0].Name);
                    code = _db.Incident.First(i => i.Code_Incident == code).Code_Incident;
                    HomeUserControl.Window.WindowPanel.Controls.Remove(this);
                    HomeUserControl.StartIssuesFromStats(code);
                }
            }
            else
            {
                MessageBox.Show(Resources.denied_access);
            }
        }

        private void resButton_Click(object sender, EventArgs e)
        {
            if (_selectedLocation != null)
            {
                new NewReservation(HomeUserControl, _selectedLocation.Location).Show();
            }
        }
    }
}
