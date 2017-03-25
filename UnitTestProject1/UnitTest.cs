using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PT_Camping;
using PT_Camping.Model;
using System.Windows.Forms;

namespace UnitTestProject
{
    [TestClass]
    public class LoginToolsTests
    {
        [TestMethod]
        public void checkConnectionSuccessfulTest()
        {
            LoginTools.Login = "mcampo";
            LoginTools.HashedPassword = LoginTools.Sha256_hash("0000");
            Assert.IsTrue(LoginTools.CheckConnection());
        }
        [TestMethod]
        public void checkConnectionFailedTest()
        {
            LoginTools.Login = "existe";
            LoginTools.HashedPassword = LoginTools.Sha256_hash("false");
            Assert.IsFalse(LoginTools.CheckConnection());
        }
        [TestMethod]
        public void checkConnectionWithoutPermissionTest()
        {
            LoginTools.Login = "sfzag";
            LoginTools.HashedPassword = LoginTools.Sha256_hash("1234");
            Assert.IsFalse(LoginTools.CheckConnection());
        }
        [TestMethod]
        public void sha256SuccessfulTest()
        {
            Assert.IsTrue(LoginTools.Sha256_hash("lesha").Equals(LoginTools.Sha256_hash("lesha")));
        }
        [TestMethod]
        public void sha256FailedTest()
        {
            Assert.IsFalse(LoginTools.Sha256_hash("unpremiersha").Equals(LoginTools.Sha256_hash("unautresha")));
        }
    }

    [TestClass]
    public class GraphicLocationTest
    {
        [TestMethod]
        public void MoveTest()
        {
            /*PictureBox pc = new PictureBox();
            DataBase db = new DataBase();
            Emplacement emplTest = new Emplacement();
            emplTest = db.Emplacement.Find(36);*/
        }
    }
}

