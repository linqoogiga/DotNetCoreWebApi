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
            //arrange:��l�ƥؼЪ���B�̪ۨ���B��k�ѼơB�w�����G�A�άO�w���P�̪ۨ��󪺤��ʤ覡�C
            int act = 1;
            int a = 100;
            int b = 5;
            int expected = 105;

            //act:�I�s�ؼЪ��󪺤�k�C
            int actual;
            actual = todoController.Count(act,a,b);
            //===
            
            //assert:���ҬO�_�ŦX�w���C
            Assert.AreEqual(expected, actual);
        }

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
    }
}
