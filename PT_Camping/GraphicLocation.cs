using PT_Camping.Model;
using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Drawing;
using System.IO;
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
        public bool Booked { get; set; }

        public GraphicLocation(Emplacement location)
        {
            this.Location = location;
            Booked = false;
            Position = new Rectangle();
        }

        public void move(Point position, Control control)
        {
            double coefWidth = (float)control.Width / 100f;
            double coefHeight = (float)control.Height / 100f;
            Location.Cordonnee_X = (float)position.X / coefWidth;
            Location.Coordonnee_Y = (float)position.Y / coefHeight;
        }

        public void resize(Size size, Control control)
        {
            double coefWidth = (float)control.Width / 100f;
            double coefHeight = (float)control.Height / 100f;
            Location.Taille_X = (float)size.Width / coefWidth;
            Location.Taille_Y = (float)size.Height / coefHeight;
        }
        
        public void draw (PaintEventArgs e, bool check)
        {
            double coefWidth = (float)e.ClipRectangle.Width / 100f;
            double coefHeight = (float)e.ClipRectangle.Height / 100f;
            if (Location != null)
            {
                Color rectangleColor = Color.LightGreen;
                if (Booked)
                {
                    rectangleColor = Color.Red;
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
                SolidBrush brush = new SolidBrush(rectangleColor);
                Position = new Rectangle(position.X, position.Y, size.Width, size.Height);
                e.Graphics.FillRectangle(brush, Position);
                brush.Dispose();
                if (Location.Type_Emplacement.Icone != null)
                {
                    MemoryStream ms = new MemoryStream(Location.Type_Emplacement.Icone);
                    Bitmap icon = new Bitmap(ms);
                    Rectangle iconPos = Position;
                    if (Position.Width > Position.Height)
                    {
                        iconPos.Width = iconPos.Height;
                        iconPos.X = iconPos.X + (Position.Width - Position.Height) / 2;
                    }
                    else
                    {
                        iconPos.Height = iconPos.Width;
                        iconPos.Y = iconPos.Y + (Position.Height - Position.Width) / 2;
                    }
                    ms.Close();
                    e.Graphics.DrawImage(icon, iconPos);
                }
                if (check)
                {
                    float[] dashValues = { 2, 2 };
                    Pen blackPen = new Pen(Color.Black, 1) {DashPattern = dashValues};
                    e.Graphics.DrawRectangle(blackPen, new Rectangle(position.X - 1, position.Y - 1, size.Width + 2, size.Height + 2));
                    blackPen.Dispose();
                }
            }
        } 
    }
}
