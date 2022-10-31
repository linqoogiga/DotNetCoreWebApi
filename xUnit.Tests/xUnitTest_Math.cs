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
            //DoSomething Free Memory。
        }

        [Fact]
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

            //assert:驗證是否符合預期。
            Assert.Equal(expected, actual);
        }

        [Fact]
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
            Assert.Equal(expected, actual);
        }

        [Fact]
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
            Assert.Equal(expected, actual);
                                                       }

        [Fact]
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
