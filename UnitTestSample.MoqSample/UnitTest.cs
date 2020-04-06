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
    /// コールバック用のデリデートを定義します
    /// </summary>
    /// <param name="value1"></param>
    /// <param name="value2"></param>
    delegate void DoSomethingCallback(string value1, ref string value2);

    [TestClass]
    public class UnitTest
    {
        [TestMethod]
        public void TestMethod()
        {
            // Arrange
            var mock = new Mock<ITestTarget>();
            // モックの振る舞いを登録します
            // ref参照の変数で値を変更します
            mock.Setup(_ => _.DoSomething(It.IsAny<string>(), ref It.Ref<string>.IsAny))
                .Callback(new DoSomethingCallback((string value1, ref string value2) => value2 = "This is output value."));
            var target = mock.Object;

            // Act
            var input = "This is input value.";
            target.DoSomething("", ref input);

            // Assert
            Assert.AreEqual("This is output value.", input);
        }
    }
}
