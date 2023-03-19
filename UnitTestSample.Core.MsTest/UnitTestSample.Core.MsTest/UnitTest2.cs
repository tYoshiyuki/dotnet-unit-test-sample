using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSample.Core.MsTest
{
    [TestClass]
    public class UnitTest2
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Trace.WriteLine("UnitTest2 ClassInitialize");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Trace.WriteLine("UnitTest2 TestInitialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Trace.WriteLine("UnitTest2 TestCleanup");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Trace.WriteLine("UnitTest2 ClassCleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Trace.WriteLine("UnitTest2 TestMethod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Trace.WriteLine("UnitTest2 TestMethod2");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Trace.WriteLine("UnitTest2 TestMethod3");
        }

    }
}
