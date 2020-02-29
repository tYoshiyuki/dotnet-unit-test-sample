using System;
using System.Diagnostics;
using Xunit;

namespace UnitTestSample.XUnit
{
    [Collection("Test Collection #1")]
    public class UnitTest3 : IClassFixture<SampleClassFixture>, IDisposable
    {
        public UnitTest3()
        {
            Trace.WriteLine("UnitTest3 TestInitialize");
        }

        public void Dispose()
        {
            Trace.WriteLine("UnitTest3 TestCleanup");
        }

        [Fact]
        public void TestMethod1()
        {
            Trace.WriteLine("UnitTest3 TestMethod1");
        }

        [Fact]
        public void TestMethod2()
        {
            Trace.WriteLine("UnitTest3 TestMethod2");
        }

        [Fact]
        public void TestMethod3()
        {
            Trace.WriteLine("UnitTest3 TestMethod3");
        }
    }
}
