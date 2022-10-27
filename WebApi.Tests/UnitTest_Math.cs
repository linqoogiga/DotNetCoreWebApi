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
            int firstNumber = 1;
            int secondNumber = 2;
            int expected = 3;

            //act:�I�s�ؼЪ��󪺤�k�C
            int actual;
            actual = todoController.Add(firstNumber, secondNumber);
            //===
            
            //assert:���ҬO�_�ŦX�w���C
            Assert.AreEqual(expected, actual);
        }
    }
}
