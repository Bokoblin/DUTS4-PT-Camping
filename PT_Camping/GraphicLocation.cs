using PT_Camping.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Windows.Forms;

namespace PT_Camping
{
    class GraphicLocation
    {
        public Emplacement Location { get; set; }
        public Rectangle Position { get; set; }

        public GraphicLocation(Emplacement location)
        {
            this.Location = location;
            Position = new Rectangle();
        }

        public void move(Point position, Control control)
        {
            float coefWidth = (float)control.Width / 100f;
            float coefHeight = (float)control.Height / 100f;
            Location.Cordonnee_X = (float)position.X / coefWidth;
            Location.Coordonnee_Y = (float)position.Y / coefHeight;
        }

        public void resize(Size size, Control control)
        {
            float coefWidth = (float)control.Width / 100f;
            float coefHeight = (float)control.Height / 100f;
            Location.Taille_X = (float)size.Width / coefWidth;
            Location.Taille_Y = (float)size.Height / coefHeight;
        }
        
        public void draw (PaintEventArgs e, bool check)
        {
            float coefWidth = (float)e.ClipRectangle.Width / 100f;
            float coefHeight = (float)e.ClipRectangle.Height / 100f;
            if (Location != null)
            {
                Color color = Color.Red;
                if (Location.Type_Emplacement.Couleur != null)
                {
                    color = Color.FromArgb(Location.Type_Emplacement.Couleur.Value);
                }
                Size size = new Size(50, 50);
                if (Location.Taille_X > 0)
                {
                    size.Width = (int)(Location.Taille_X * coefWidth);
                }
                if (Location.Taille_Y > 0)
                {
                    size.Height = (int)(Location.Taille_Y * coefHeight);
                }
                Point position = new Point();
                position.X = (int)(Location.Cordonnee_X * coefWidth);
                position.Y = (int)(Location.Coordonnee_Y * coefHeight);
                SolidBrush brush = new SolidBrush(Color.Red);
                Position = new Rectangle(position.X, position.Y, size.Width, size.Height);
                e.Graphics.FillRectangle(brush, Position);
                brush.Dispose();
                if (check)
                {
                    float[] dashValues = { 2, 2 };
                    Pen blackPen = new Pen(Color.Black, 1);
                    blackPen.DashPattern = dashValues;
                    e.Graphics.DrawRectangle(blackPen, new Rectangle(position.X - 1, position.Y - 1, size.Width + 2, size.Height + 2));
                    blackPen.Dispose();
                }
            }
        } 

        public void saveToDB(DataBase db)
        {
            if (Location != null)
            {
                LoginTools.checkConnection();
                Emplacement location2 = db.Emplacement.First(e => e.Code_Emplacement == Location.Code_Emplacement);
                db.Entry(location2).CurrentValues.SetValues(Location);
                location2.Type_Emplacement = db.Type_Emplacement.Where(a => a.Code_Type == Location.Type_Emplacement.Code_Type).First();
                location2.Caracteristique_Emplacement.Clear();
                foreach (var car in Location.Caracteristique_Emplacement)
                {
                    location2.Caracteristique_Emplacement.Add(db.Caracteristique_Emplacement.Where(a => a.Code_Caracteristique == car.Code_Caracteristique).First());
                }
                db.SaveChanges();
            }
        }
    }
}
