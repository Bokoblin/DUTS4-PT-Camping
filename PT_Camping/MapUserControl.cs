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
        private Bitmap image;
        private MapMode mode;
        private List<GraphicLocation> locationsList;
        private GraphicLocation selectedLocation;
        private bool moving;
        private Point offsetMoving;
        private Point startClick;
        private Size oldSize;
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
            DataBase db = new DataBase();
            List<Emplacement> locations = db.Emplacement.ToList();
            locationsList = new List<GraphicLocation>();
            foreach(Emplacement loc in locations)
            {
                locationsList.Add(new GraphicLocation(loc));
            }
            List<Type_Emplacement> typesLocations = db.Type_Emplacement.ToList();
            int i = 0;
            foreach(Type_Emplacement type in typesLocations)
            {
                Button button = new Button();
                button.Click += addLocationClick;
                button.Text = type.Libelle_Type;
                button.Height = 30;
                button.Top = i * (button.Height+10);
                button.Left = 10;
                if (type.Icone != null)
                {
                    MemoryStream ms = new MemoryStream(db.App.FirstOrDefault().Fond_Image);
                    button.Image = new Bitmap(ms);
                    ms.Close();
                    button.ImageAlign = ContentAlignment.MiddleRight;
                }
                button.Anchor = AnchorStyles.Top | AnchorStyles.Left;
                addLocationPanel.Controls.Add(button);
                i++;

                categoriesCheckedListBox.Items.Add(type.Libelle_Type, true);
            }

            //if (db.App.Where(m => m.Fond_Image != null).Count() < 1)
            if (true)
            {
                mode = MapMode.LOAD_IMAGE;
            } else
            {
                MemoryStream ms = new MemoryStream(db.App.FirstOrDefault().Fond_Image);
                image = new Bitmap(ms);
                ms.Close();
                mode = MapMode.NORMAL;
            }
            changeMode(mode);
        }

        private void changeMode (MapMode mode)
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
                        /*LoginTools.checkConnection();
                        DataBase db = new DataBase();
                        App app = db.App.FirstOrDefault();
                        if (app == null)
                        {
                            app = new App();
                            db.App.Add(app);
                        }
                        ImageConverter converter = new ImageConverter();
                        app.Fond_Image = (byte[])converter.ConvertTo(image, typeof(byte[]));
                        db.SaveChanges();*/
                        if (image == null)
                        {
                            throw new FileLoadException();
                        }
                        pictureBox.Image = image;
                        mode = MapMode.NORMAL;
                        changeMode(mode);
                    } catch (FileNotFoundException)
                    {
                        MessageBox.Show("Fichier non trouvé ! Veuillez réessayer.");
                    } catch (FileLoadException)
                    {
                        MessageBox.Show("Erreur lors de l'ouverture du fichier, veuillez réessayer.");
                    }
                }
            }
        }

        private void addLocationClick(object sender, EventArgs e)
        {

        }

        private void modeCheckBox_CheckedChanged(object sender, EventArgs e)
        {
            if (((CheckBox)sender).Checked)
            {
                mode = MapMode.EDIT;
            } else
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
                    } else
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
                } else
                {
                    Cursor = Cursors.Default;
                }
            } else
            {
                Cursor = Cursors.Default;
            }
            if (moving && selectedLocation!= null)
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
                            newPosition.X = selectedLocation.Position.X;
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
                            newPosition.Y = selectedLocation.Position.Y;
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
            foreach(GraphicLocation location in locationsList)
            {
                if (location.Position.Contains(e.Location))
                {
                    selectedLocation = location;
                    selected = true;
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
                if (cursorAction != CursorAction.DEFAULT && mode == MapMode.EDIT)
                {
                    moving = true;
                    startClick = e.Location;
                    oldSize = selectedLocation.Position.Size;
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
            DataBase db = new DataBase();
            foreach(GraphicLocation location in locationsList)
            {
                location.saveToDB(db);
            }
        }
    }
}
