using System.Diagnostics;
using NUnit.Framework;

namespace UnitTestSample.NUnit
{
    public class UnitTest1
    {
        [OneTimeSetUp]
        public void ClassInitialize()
        {
            Trace.WriteLine("UnitTest1 ClassInitialize");
        }

        [SetUp]
        public void TestInitialize()
        {
            Trace.WriteLine("UnitTest1 TestInitialize");
        }

        [TearDown]
        public void TestCleanup()
        {
            Trace.WriteLine("UnitTest1 TestCleanup");
        }

        [OneTimeTearDown]
        public static void ClassCleanup()
        {
            Trace.WriteLine("UnitTest1 ClassCleanup");
        }

        [Test]
        public void TestMethod1()
        {
            Trace.WriteLine("UnitTest1 TestMethod1");
        }

        [Test]
        public void TestMethod2()
        {
            Trace.WriteLine("UnitTest1 TestMethod2");
        }

        [Test]
        public void TestMethod3()
        {
            Trace.WriteLine("UnitTest1 TestMethod3");
        }
    }
}