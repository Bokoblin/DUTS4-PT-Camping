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
        public void checkConnectionTest()
        {
            LoginTools login = new LoginTools();
            login.Login = "mcampo";
            login.HashedPassword = LoginTools.sha256_hash("0000");
            login.checkConnection();
        }
    }

    [TestClass]
    public class StockUserControlTest
    {

    }
}
