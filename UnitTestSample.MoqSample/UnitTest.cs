using System;
using System.Linq.Expressions;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using Moq;

namespace UnitTestSample.MoqSample
{
    /// <summary>
    /// テスト対象となるインターフェースです
    /// </summary>
    public interface ITestTarget
    {
        void DoSomething(string value1, ref string value2);
    }

    /// <summary>
    /// テスト対象となるインターフェースです
    /// </summary>
    public interface ITestTargetV2
    {
        void DoSomething(string value1, string value2);
    }

    /// <summary>
    /// コールバック用のデリデートを定義します
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    delegate void DoSomethingCallback(string value1, ref string value2);

    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod01()
        {
            // Arrange
            var mock = new Mock<ITestTarget>();
            // モックの振る舞いを登録します
            // ref参照の変数で値を変更します
            mock.Setup(x => x.DoSomething(It.IsAny<string>(), ref It.Ref<string>.IsAny))
                .Callback(new DoSomethingCallback((string value1, ref string value2) => value2 = "This is output value."));
            var target = mock.Object;

            // Act
            var input = "This is input value.";
            target.DoSomething("", ref input);

            // Assert
            Assert.AreEqual("This is output value.", input);
        }

        [TestMethod]
        public void TestMethod02()
        {
            // Arrange
            var mock = new Mock<ITestTargetV2>();

            // モックの振る舞いを登録します
            Expression<Action<ITestTargetV2>> doSomething = x => x.DoSomething(It.IsAny<string>(), It.IsAny<string>());
            mock.Setup(doSomething);
            var target = mock.Object;

            // Act
            target.DoSomething("This is input value1.", "This is input value2.");

            // Assert
            mock.Verify(v => v.DoSomething(AssertValue1(), AssertValue2()));
        }

        /// <summary>
        /// テスト結果検証用のメソッドです
        /// </summary>
        /// <returns></returns>
        public string AssertValue1()
        {
            return Match.Create<string>(s => s == "This is input value1.");
        }

        /// <summary>
        /// テスト結果検証用のメソッドです
        /// </summary>
        /// <returns></returns>
        public string AssertValue2()
        {
            return Match.Create<string>(s =>
            {
                // 下記の通り、アサーションを独自に書くこともできます
                Assert.AreEqual("This is input value2.", s);
                return true;
            });
        }
    }
}
