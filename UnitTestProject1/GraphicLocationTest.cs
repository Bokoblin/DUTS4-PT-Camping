using PT_Camping.Model;
using System.Windows.Forms;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using Assert = NUnit.Framework.Assert;

namespace UnitTestProject
{
    /// <summary>
    /// This test class is used to test the PT_Camping.Model.GraphicLocation class.
    /// 
    /// </summary>
    /// Authors : Arthur
    /// Since : 25/03/17
    [TestClass]
    public class GraphicLocationTest
    {
        [TestMethod]
        public void InstanceTest()
        {
            var e1 = new PT_Camping.Model.Emplacement { Nom_Emplacement = "e1" };
            var graphicLocation = new GraphicLocation(e1);

            Assert.AreEqual(e1, graphicLocation.Location);
            Assert.IsFalse(graphicLocation.Booked);
        }


        [TestMethod]
        public void MoveTest()
        {
            var e1 = new PT_Camping.Model.Emplacement
            {
                Nom_Emplacement = "e1",
                Cordonnee_X = 5,
                Coordonnee_Y = 5

            };
            var graphicLocation = new GraphicLocation(e1);


            //Check position before
            Assert.AreEqual(graphicLocation.Location.Cordonnee_X, 5);
            Assert.AreEqual(graphicLocation.Location.Coordonnee_Y, 5);

            PictureBox pb = new PictureBox
            {
                Width = 100,
                Height = 100
            };

            graphicLocation.Move(new System.Drawing.PointF(
                (float)(graphicLocation.Location.Cordonnee_X + 10),
                (float)(graphicLocation.Location.Coordonnee_Y + 25)), pb);

            //Check position after
            Assert.AreEqual(graphicLocation.Location.Cordonnee_X, 15);
            Assert.AreEqual(graphicLocation.Location.Coordonnee_Y, 30);
        }


        [TestMethod]
        public void ResizeTest()
        {
            var e1 = new PT_Camping.Model.Emplacement
            {
                Nom_Emplacement = "e1",
                Cordonnee_X = 5,
                Coordonnee_Y = 5,
                Taille_X = 50,
                Taille_Y = 50
            };
            var graphicLocation = new GraphicLocation(e1);


            //Check position before
            Assert.AreEqual(graphicLocation.Location.Taille_X, 50);
            Assert.AreEqual(graphicLocation.Location.Taille_Y, 50);

            PictureBox pb = new PictureBox
            {
                Width = 100,
                Height = 50
            };

            graphicLocation.Resize(new System.Drawing.SizeF(15, 10), pb);

            //Check position after
            Assert.AreEqual(graphicLocation.Location.Taille_X, 15);
            Assert.AreEqual(graphicLocation.Location.Taille_Y, 20); //picture box height is half sized
        }
    }
}
