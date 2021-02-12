using Microsoft.VisualStudio.TestTools.UnitTesting;
using System;
using EPOSLibrary;
using System.Diagnostics;

namespace UnitTests
{
    [TestClass]
    public class DataAccessTests
    {
        [TestMethod]
        public void TestMethod1()
        {
            Trace.WriteLine(Hashing.NewHash("hellothere", "1234"));
        }
    }
}
