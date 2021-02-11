using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EPOSLibrary.DataAccess;

namespace UnitTests
{
    [TestClass]
    public class DataAccessTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Console.WriteLine(RoleDataAccess.Load(1));
        }
    }
}
