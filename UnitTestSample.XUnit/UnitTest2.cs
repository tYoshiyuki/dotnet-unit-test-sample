using System;
using System.Diagnostics;
using Xunit;

namespace UnitTestSample.XUnit
{
    [Collection("Test Collection #1")]
    public class UnitTest2 : IClassFixture<SampleClassFixture>, IDisposable
    {
        public UnitTest2()
        {
            Trace.WriteLine("UnitTest2 TestInitialize");
        }

        public void Dispose()
        {
            Trace.WriteLine("UnitTest2 TestCleanup");
        }

        [Fact]
        public void TestMethod1()
        {
            Trace.WriteLine("UnitTest2 TestMethod1");
        }

        [Fact]
        public void TestMethod2()
        {
            Trace.WriteLine("UnitTest2 TestMethod2");
        }

        [Fact]
        public void TestMethod3()
        {
            Trace.WriteLine("UnitTest3 TestMethod3");
        }

    }
}
