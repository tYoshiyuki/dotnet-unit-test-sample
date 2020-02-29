using System.Diagnostics;
using NUnit.Framework;

namespace UnitTestSample.NUnit
{
    public class UnitTest2
    {
        [OneTimeSetUp]
        public void ClassInitialize()
        {
            Trace.WriteLine("UnitTest2 ClassInitialize");
        }

        [SetUp]
        public void TestInitialize()
        {
            Trace.WriteLine("UnitTest2 TestInitialize");
        }

        [TearDown]
        public void TestCleanup()
        {
            Trace.WriteLine("UnitTest2 TestCleanup");
        }

        [OneTimeTearDown]
        public static void ClassCleanup()
        {
            Trace.WriteLine("UnitTest2 ClassCleanup");
        }

        [Test]
        public void TestMethod1()
        {
            Trace.WriteLine("UnitTest2 TestMethod1");
        }

        [Test]
        public void TestMethod2()
        {
            Trace.WriteLine("UnitTest2 TestMethod2");
        }

        [Test]
        public void TestMethod3()
        {
            Trace.WriteLine("UnitTest2 TestMethod3");
        }
    }
}