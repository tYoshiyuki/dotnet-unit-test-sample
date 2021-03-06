using System;
using System.Diagnostics;
using Xunit;

namespace UnitTestSample.XUnit
{
    [Collection("Test Collection #1")]
    public class UnitTest1 : IClassFixture<SampleClassFixture>, IDisposable
    {
        public UnitTest1()
        {
            Trace.WriteLine("UnitTest1 TestInitialize");
        }

        public void Dispose()
        {
            Trace.WriteLine("UnitTest1 TestCleanup");
        }

        [Fact]
        public void TestMethod1()
        {
            Trace.WriteLine("UnitTest1 TestMethod1");
        }

        [Fact]
        public void TestMethod2()
        {
            Trace.WriteLine("UnitTest1 TestMethod2");
        }

        [Fact]
        public void TestMethod3()
        {
            Trace.WriteLine("UnitTest1 TestMethod3");
        }
    }
}
