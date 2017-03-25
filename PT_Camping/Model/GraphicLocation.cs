using System.Drawing;
using System.IO;
using System.Windows.Forms;

namespace PT_Camping.Model
{
    internal class GraphicLocation
    {
        public Emplacement Location { get; set; }
        public RectangleF Position { get; set; }
        public bool Booked { get; set; }

        public GraphicLocation(Emplacement location)
        {
            Location = location;
            Booked = false;
            Position = new Rectangle();
        }

        public void Move(PointF position, Control control)
        {
            double coefWidth = (float)control.Width / 100f;
            double coefHeight = (float)control.Height / 100f;
            Location.Cordonnee_X = position.X / coefWidth;
            Location.Coordonnee_Y = position.Y / coefHeight;
        }

        public void Resize(SizeF size, Control control)
        {
            double coefWidth = (float)control.Width / 100f;
            double coefHeight = (float)control.Height / 100f;
            Location.Taille_X = size.Width / coefWidth;
            Location.Taille_Y = size.Height / coefHeight;
        }
        
        public void Draw (PaintEventArgs e, bool check, Control control)
        {
            double coefWidth = (float)control.Width / 100f;
            double coefHeight = (float)control.Height / 100f;
            if (Location != null)
            {
                Color rectangleColor = Color.Gray;
                if (Location.Type_Emplacement.Est_Reservable)
                {
                    rectangleColor = Booked ? Color.Red : Color.LightGreen;
                }
                SizeF size = new Size(50, 50);
                if (Location.Taille_X > 0)
                {
                    size.Width = (float)(Location.Taille_X * coefWidth);
                }
                if (Location.Taille_Y > 0)
                {
                    size.Height = (float)(Location.Taille_Y * coefHeight);
                }
                PointF position = new PointF()
                {
                    X = (float)(Location.Cordonnee_X * coefWidth),
                    Y = (float)(Location.Coordonnee_Y * coefHeight)
                };
                SolidBrush brush = new SolidBrush(rectangleColor);
                Position = new RectangleF(position.X, position.Y, size.Width, size.Height);
                e.Graphics.FillRectangle(brush, Position);
                brush.Dispose();
                if (Location.Type_Emplacement.Icone != null)
                {
                    MemoryStream ms = new MemoryStream(Location.Type_Emplacement.Icone);
                    Bitmap icon = new Bitmap(ms);
                    RectangleF iconPos = Position;
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
                    e.Graphics.DrawRectangle(blackPen, position.X - 1, position.Y - 1, size.Width + 2, size.Height + 2);
                    blackPen.Dispose();
                }
            }
        } 
    }
}
