using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;

namespace WebApi.Tests
{
    [TestClass]
    public class UnitTest1
    {
        private MathController todoController;

        [TestInitialize]
        public void SetUp()
        {
            todoController = new MathController();
        }

        [TestMethod]
        public void Test_Add()
        {
            //arrange:初始化目標物件、相依物件、方法參數、預期結果，或是預期與相依物件的互動方式。
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 3;

            //act:呼叫目標物件的方法。
            int actual;
            actual = todoController.Add(firstNumber, secondNumber);
            //===
            
            //assert:驗證是否符合預期。
            Assert.AreEqual(expected, actual);
        }
    }
}
