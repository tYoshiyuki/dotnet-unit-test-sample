using System.Diagnostics;
using Microsoft.VisualStudio.TestTools.UnitTesting;

// NOTE ClassCleanup の 動作タイミングをアセンブリ単位 (全テスト終了時) で無く、クラス単位に変更する。
[assembly: ClassCleanupExecution(ClassCleanupBehavior.EndOfClass)]

namespace UnitTestSample.Core.MsTest.V3
{
    [TestClass]
    public class AssemblyInitializer
    {
        [AssemblyInitialize]
        public static void AssemblyInitialize(TestContext context)
        {
            Trace.WriteLine("AssemblyInitializer AssemblyInitialize");
        }

        [AssemblyCleanup]
        public static void AssemblyCleanup()
        {
            Trace.WriteLine("AssemblyInitializer AssemblyCleanup");
        }
    }
}
