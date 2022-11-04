using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;
using BLL;
using System.IO;
using System.Threading;

namespace WebApi.Tests
{
    [TestClass]
    public class UnitTest_Math
    {
        private MathController todoController;
        [AssemblyInitialize]
        public static void Init_ASSM(TestContext testcontext)
        {
        }

        [ClassInitialize]
        public static void Init(TestContext testcontext)
        {
            //Only Run Once
        }

        [ClassCleanup]
        public static void Once_Dispose()
        {
            //Only Run Once_Dispose
        }

        [TestInitialize]
        public void SetUp()
        {
            IMath _math = new BLL.Math();
            todoController = new MathController(_math);
        }

        [TestCleanup]
        public void Dispose()
        {
            //DoSomething Free Memory。
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
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
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

        [TestMethod()]
        public void All_Assert_Method()
        {
            Assert.AreNotEqual(1, 2);
            //===
            Assert.AreNotSame(new[] { 1, 2 }, new[] { 1, 2 });
            //===
            int[] array = new[] { 1, 2 };
            Assert.AreSame(array, array);
            //===
            //Assert.Fail();RA
            //===
            Assert.IsFalse(1 == 2);
            //===
            Assert.IsNotNull(1 == 1);
            Assert.IsNotNull(false);
            //===
            Assert.IsNull(null);
            //===
            Assert.IsTrue(1 == 1);
            Assert.IsTrue(true);                        
        }
        //=========================================================
        [TestMethod]
        public void Test_Z1()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z2()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z3()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z4()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z5()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z6()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z7()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z8()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z9()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z10()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z11()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z12()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z13()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z14()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z15()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z16()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z17()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z18()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z19()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z20()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z21()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z22()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z23()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z24()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z25()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z26()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z27()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z28()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z29()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z30()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z31()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z32()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z33()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z34()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z35()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z36()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z37()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z38()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z39()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z40()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z41()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z42()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z43()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z44()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z45()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z46()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z47()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z48()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z49()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================
        [TestMethod]
        public void Test_Z50()
        {
            //arrange:
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:
            int actual;
            actual = todoController.Count(act, a, b);
            //===
            //Thread.Sleep(1000);
            //assert:
            Assert.AreEqual(expected, actual);
        }
        //===============================


    }
}


