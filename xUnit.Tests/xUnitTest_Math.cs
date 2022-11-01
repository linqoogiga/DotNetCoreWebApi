using System;
using Xunit;
using WebApi.Controllers;
using BLL;

namespace xUnit.Tests
{
    public class xUnitTest_Math:IDisposable
    {
        private MathController todoController;
        
        public  xUnitTest_Math()
        {
            IMath _math = new BLL.Math();
            todoController = new MathController(_math);
        }

        public void Dispose()
        {
            //DoSomething Free Memory�C
        }

        [Fact]
        public void Test_Add()
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
            Assert.Equal(expected, actual);
        }

        [Fact]
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
            Assert.Equal(expected, actual);
        }

        [Fact]
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
            Assert.Equal(expected, actual);
                                                       }

        [Fact]
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
            Assert.Equal(expected, actual);
        }

        [Fact]
        public void All_Assert_Method()
        {
            Assert.NotEqual(1, 2);
            //===
            Assert.NotSame(new[] { 1, 2 }, new[] { 1, 2 });
            //===
            int[] array = new[] { 1, 2 };
            Assert.Same(array, array);
            //===
            //Assert.Fail();
            //===
            Assert.False(1 == 2);
            //===
            Assert.NotNull(1 == 1);
            Assert.NotNull(false);
            //===
            Assert.Null(null);
            //===
            Assert.True(1 == 1);
            Assert.True(true);
        }
    }
}
