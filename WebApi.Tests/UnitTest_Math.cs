using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;
using BLL;

namespace WebApi.Tests
{
    [TestClass]
    public class UnitTest_Math
    {
        private MathController todoController;                
        [TestInitialize]                
        public void SetUp()
        {
            IMath _math = new Math();
        todoController = new MathController(_math);
        }

        [TestMethod]
        public void Test_Add()
        {
            //arrange:初始化目標物件、相依物件、方法參數、預期結果，或是預期與相依物件的互動方式。
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:呼叫目標物件的方法。
            int actual;
            actual = todoController.Count(act,a,b);
            //===
            
            //assert:驗證是否符合預期。
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Minus()
        {
            //arrange:初始化目標物件、相依物件、方法參數、預期結果，或是預期與相依物件的互動方式。
            int act = 2;
            int a = 100;
            int b = 5;
            int expected = 95;

            //act:呼叫目標物件的方法。
            int actual;
            actual = todoController.Count(act, a, b);
            //===

            //assert:驗證是否符合預期。
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Multiple()
        {
            //arrange:初始化目標物件、相依物件、方法參數、預期結果，或是預期與相依物件的互動方式。
            int act = 3;
            int a = 100;
            int b = 5;
            int expected = 500;

            //act:呼叫目標物件的方法。
            int actual;
            actual = todoController.Count(act, a, b);
            //===

            //assert:驗證是否符合預期。
            Assert.AreEqual(expected, actual);
        }

        [TestMethod]
        public void Test_Divide()
        {
            //arrange:初始化目標物件、相依物件、方法參數、預期結果，或是預期與相依物件的互動方式。
            int act = 4;
            int a = 100;
            int b = 5;
            int expected = 20;

            //act:呼叫目標物件的方法。
            int actual;
            actual = todoController.Count(act, a, b);
            //===

            //assert:驗證是否符合預期。
            Assert.AreEqual(expected, actual);
        }
    }
}
