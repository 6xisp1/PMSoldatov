using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;

namespace UnitTestSoldatov
{
    [TestClass]
    public class UnitTest1
    {
        [TestMethod]
        public void login()
        {
            bool expect = true;
            bool result = MainWindow.Validation("admin", "admin");
            Assert.AreEqual(expect, result);
        }
        [TestMethod]
        public void TestAvtr()
        {
            String Login = "admin";
            String Password = "admin";
            bool expect = true;
            bool result = MainWindow.TestAvtr(Password, Login);
            Assert.AreEqual(expect, result);
        }
    }
}
