using NUnit.Framework;
using WebApi.Controllers;
using BLL;

namespace NUnit.Tests
{
    [TestFixture]
    public class NUnitTest_Math
    {
        private MathController todoController;
        [OneTimeSetUp]
        public static void Init()
        {
            //Only Run Once
        }
  
        [OneTimeTearDown]
        public static void Once_Dispose()
        {
            //Only Run Once_Dispose
        }

        [SetUp]
        public void Setup()
        {
            IMath _math = new BLL.Math();
            todoController = new MathController(_math);
        }

        [TearDown]
        public void Dispose()
        {
            //DoSomething Free Memory。
        }

        [Repeat(2)]
        [Test]
        [TestCase(2, 3)]
        [TestCase(5, 6)]
        public void Test_Add(int x,int y)
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

            //assert:驗證是否符合預期。
            Assert.AreEqual(expected, actual);
        }

        [Test]
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

        [Test]
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

        [Test]
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

        [Test]
        public void All_Assert_Method()
        {
            Assert.AreNotEqual(1, 2);
            //===
            Assert.AreNotSame(new[] { 1, 2 }, new[] { 1, 2 });
            //===
            int[] array = new[] { 1, 2 };
            Assert.AreSame(array, array);
            //===
            //Assert.Fail();
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
    }
}