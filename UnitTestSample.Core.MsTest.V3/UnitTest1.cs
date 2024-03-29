using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

namespace UnitTestSample.Core.MsTest.V3
{
    [TestClass]
    public class UnitTest1
    {
        [ClassInitialize]
        public static void ClassInitialize(TestContext testContext)
        {
            Trace.WriteLine("UnitTest1 ClassInitialize");
        }

        [TestInitialize]
        public void TestInitialize()
        {
            Trace.WriteLine("UnitTest1 TestInitialize");
        }

        [TestCleanup]
        public void TestCleanup()
        {
            Trace.WriteLine("UnitTest1 TestCleanup");
        }

        [ClassCleanup]
        public static void ClassCleanup()
        {
            Trace.WriteLine("UnitTest1 ClassCleanup");
        }

        [TestMethod]
        public void TestMethod1()
        {
            Trace.WriteLine("UnitTest1 TestMethod1");
        }

        [TestMethod]
        public void TestMethod2()
        {
            Trace.WriteLine("UnitTest1 TestMethod2");
        }

        [TestMethod]
        public void TestMethod3()
        {
            Trace.WriteLine("UnitTest1 TestMethod3");
        }
    }
}
