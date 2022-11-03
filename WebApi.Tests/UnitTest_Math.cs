using Microsoft.VisualStudio.TestTools.UnitTesting;
using WebApi.Controllers;
using BLL;
using System.IO;

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
            //DoSomething Free Memory�C
        }

        [TestMethod]
        [DataRow(1, 2)]
        [DataRow(3, 6)]
        public void Test_Add(int x, int y)
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

        [TestCategory("CategoryA")]
        [TestMethod]
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

        [Priority(1)]
        [TestMethod]
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

        [Priority(0)]
        [TestMethod]
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

        [TestMethod()]
        [ExpectedException(typeof(AngryException))]
        public void WorktimeTest()
        {
            todoController.WorkTime(15);
        }

        [TestMethod()]
        [ExpectedException(typeof(AngryException),"ZA_HaHa")]
        public void WorktimeTest_Message()
        {
            todoController.WorkTime(15);
        }
    }
}


