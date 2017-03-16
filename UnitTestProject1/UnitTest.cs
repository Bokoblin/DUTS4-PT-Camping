using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using PT_Camping;
using PT_Camping.Model;

namespace UnitTestProject
{
    [TestClass]
    public class LoginToolsTests
    {
        [TestMethod]
        public void checkConnectionSuccessfulTest()
        {
            LoginTools login = new LoginTools();
            login.Login = "mcampo";
            login.HashedPassword = LoginTools.sha256_hash("0000");
            Assert.IsTrue(login.checkConnection());
        }
        [TestMethod]
        public void checkConnectionFailedTest()
        {
            LoginTools login = new LoginTools();
            login.Login = "existe";
            login.HashedPassword = LoginTools.sha256_hash("false");
            Assert.IsFalse(login.checkConnection());
        }
        [TestMethod]
        public void checkConnectionWithoutPermissionTest()
        {
            LoginTools login = new LoginTools();
            login.Login = "sfzag";
            login.HashedPassword = LoginTools.sha256_hash("1234");
            Assert.IsFalse(login.checkConnection());
        }
        [TestMethod]
        public void sha256SuccessfulTest()
        {
            Assert.IsTrue(LoginTools.sha256_hash("lesha").Equals(LoginTools.sha256_hash("lesha")));
        }
        [TestMethod]
        public void sha256FailedTest()
        {
            Assert.IsFalse(LoginTools.sha256_hash("unpremiersha").Equals(LoginTools.sha256_hash("unautresha")));
        }
    }
}
