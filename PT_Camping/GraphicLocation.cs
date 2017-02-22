using PT_Camping.Model;
using System;
using System.Collections.Generic;
using System.Drawing;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace PT_Camping
{
    class GraphicLocation
    {
        public Emplacement Location { get; set; }

        public GraphicLocation(Emplacement location)
        {
            this.Location = location;
        }
        
        public void draw (Graphics e, bool check)
        {
            if (Location != null)
            {
                Color color = Color.Red;
                if (Location.Type_Emplacement.Couleur != null)
                {
                    color = Color.FromArgb(Location.Type_Emplacement.Couleur.Value);
                }
                SizeF size = new SizeF(5.0f, 5.0f);
                if (Location.Taille_X > 0)
                {
                    size.Width = (float)Location.Taille_X;
                }
                if (Location.Taille_Y > 0)
                {
                    size.Height = (float)Location.Taille_Y;
                }
                SolidBrush brush = new SolidBrush(Color.Red);
                e.FillRectangle(brush, new Rectangle((int)Location.Cordonnee_X, (int)Location.Coordonnee_Y, (int)size.Width, (int)size.Height));
                float[] dashValues = { 2, 2 };
                Pen blackPen = new Pen(Color.Black, 1);
                blackPen.DashPattern = dashValues;
                e.DrawRectangle(blackPen, new Rectangle((int)Location.Cordonnee_X - 1, (int)Location.Coordonnee_Y - 1, (int)size.Width + 2, (int)size.Height + 2));
                brush.Dispose();
            }
        } 

        public void saveToDB(DataBase db)
        {
            if (Location != null)
            {
                LoginTools.checkConnection();
                Emplacement location2 = db.Emplacement.First(e => e.Code_Emplacement == Location.Code_Emplacement);
                location2 = Location;
                db.SaveChanges();
            }
        }
    }
}
