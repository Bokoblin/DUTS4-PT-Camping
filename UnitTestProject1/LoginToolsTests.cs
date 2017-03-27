using PT_Camping.Model;
using TestClass = NUnit.Framework.TestFixtureAttribute;
using TestMethod = NUnit.Framework.TestAttribute;
using Assert = NUnit.Framework.Assert;


namespace UnitTestProject
{
    /// <summary>
    /// This test class is used to test the PT_Camping.Model.LoginTools class.
    /// 
    /// </summary>
    /// Authors : Yonnel
    /// Since : 16/02/17
    [TestClass]
    public class LoginToolsTests
    {
        [TestMethod]
        public void CheckConnectionSuccessfulTest()
        {
            LoginTools.Login = "test-connection";
            LoginTools.HashedPassword = LoginTools.Sha256_hash("success");
            Assert.IsTrue(LoginTools.CheckConnection());
        }


        [TestMethod]
        public void CheckConnectionFailedTest()
        {
            LoginTools.Login = "existe";
            LoginTools.HashedPassword = LoginTools.Sha256_hash("false");
            Assert.IsFalse(LoginTools.CheckConnection());
        }


        [TestMethod]
        public void CheckConnectionFailedWithoutPermissionTest()
        {
            LoginTools.Login = "test-licencie";
            LoginTools.HashedPassword = LoginTools.Sha256_hash("1234");
            Assert.IsFalse(LoginTools.CheckConnection());
        }


        [TestMethod]
        public void Sha256SuccessfulTest()
        {
            Assert.IsTrue(LoginTools.Sha256_hash("lesha").Equals(LoginTools.Sha256_hash("lesha")));
        }


        [TestMethod]
        public void Sha256FailedTest()
        {
            Assert.IsFalse(LoginTools.Sha256_hash("unpremiersha").Equals(LoginTools.Sha256_hash("unautresha")));
        }
    }
}

