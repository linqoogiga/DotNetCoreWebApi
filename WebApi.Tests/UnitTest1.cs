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
