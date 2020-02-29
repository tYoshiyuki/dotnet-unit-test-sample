using System.Diagnostics;
using NUnit.Framework;

namespace UnitTestSample.NUnit
{
    public class UnitTest3
    {
        [OneTimeSetUp]
        public void ClassInitialize()
        {
            Trace.WriteLine("UnitTest3 ClassInitialize");
        }

        [SetUp]
        public void TestInitialize()
        {
            Trace.WriteLine("UnitTest3 TestInitialize");
        }

        [TearDown]
        public void TestCleanup()
        {
            Trace.WriteLine("UnitTest3 TestCleanup");
        }

        [OneTimeTearDown]
        public static void ClassCleanup()
        {
            Trace.WriteLine("UnitTest3 ClassCleanup");
        }

        [Test]
        public void TestMethod1()
        {
            Trace.WriteLine("UnitTest3 TestMethod1");
        }

        [Test]
        public void TestMethod2()
        {
            Trace.WriteLine("UnitTest3 TestMethod2");
        }

        [Test]
        public void TestMethod3()
        {
            Trace.WriteLine("UnitTest3 TestMethod3");
        }
    }
}