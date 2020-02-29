using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSample.MsTest
{
    [TestClass]
    public class UnitTest3
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Trace.WriteLine("UnitTest3 ClassInitialize");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Trace.WriteLine("UnitTest3 TestInitialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Trace.WriteLine("UnitTest3 TestCleanup");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Trace.WriteLine("UnitTest3 ClassCleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Trace.WriteLine("UnitTest3 TestMethod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Trace.WriteLine("UnitTest3 TestMethod2");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Trace.WriteLine("UnitTest3 TestMethod3");
        }

    }
}
