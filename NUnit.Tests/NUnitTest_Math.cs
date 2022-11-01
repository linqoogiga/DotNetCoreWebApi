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
            //DoSomething Free Memory�C
        }

        [Repeat(2)]
        [Test]
        [TestCase(2, 3)]
        [TestCase(5, 6)]
        public void Test_Add(int x,int y)
        {
            //arrange:��l�ƥؼЪ���B�̪ۨ���B��k�ѼơB�w�����G�A�άO�w���P�̪ۨ��󪺤��ʤ覡�C
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:�I�s�ؼЪ��󪺤�k�C
            int actual;
            actual = todoController.Count(act, a, b);
            //===

            //assert:���ҬO�_�ŦX�w���C
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Minus()
        {
            //arrange:��l�ƥؼЪ���B�̪ۨ���B��k�ѼơB�w�����G�A�άO�w���P�̪ۨ��󪺤��ʤ覡�C
            int act = 2;
            int a = 100;
            int b = 5;
            int expected = 95;

            //act:�I�s�ؼЪ��󪺤�k�C
            int actual;
            actual = todoController.Count(act, a, b);
            //===

            //assert:���ҬO�_�ŦX�w���C
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Multiple()
        {
            //arrange:��l�ƥؼЪ���B�̪ۨ���B��k�ѼơB�w�����G�A�άO�w���P�̪ۨ��󪺤��ʤ覡�C
            int act = 3;
            int a = 100;
            int b = 5;
            int expected = 500;

            //act:�I�s�ؼЪ��󪺤�k�C
            int actual;
            actual = todoController.Count(act, a, b);
            //===

            //assert:���ҬO�_�ŦX�w���C
            Assert.AreEqual(expected, actual);
        }

        [Test]
        public void Test_Divide()
        {
            //arrange:��l�ƥؼЪ���B�̪ۨ���B��k�ѼơB�w�����G�A�άO�w���P�̪ۨ��󪺤��ʤ覡�C
            int act = 4;
            int a = 100;
            int b = 5;
            int expected = 20;

            //act:�I�s�ؼЪ��󪺤�k�C
            int actual;
            actual = todoController.Count(act, a, b);
            //===

            //assert:���ҬO�_�ŦX�w���C
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