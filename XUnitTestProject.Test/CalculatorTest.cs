using System;
using System.Collections.Generic;
using System.Text;
using UnitTest.APP;
using Xunit;

namespace XUnitTestProject.Test
{
    public class CalculatorTest
    {
        public Calculator calculator { get; set; }
        public CalculatorTest()
        {
            this.calculator = new Calculator();
        }
        [Fact]
        public void AddTest()
        {
            //Arrange : değişkenlerimin initialize ettiğim yer.değer vermek veya nesne örneği oluşturacağım yer.
            int a = 5;
            int b = 7;

            //Act : initailze ettiğimiz classlara parametreler verip test edeceğimiz metotları çalıştıracağımız yer .
            var total = calculator.add(a,b);


            //Assert : doğrulama evresi
            Assert.Equal(12, total);
        }

        [Theory]
        [InlineData(3,5,8)]
        [InlineData(3, 8, 11)]
        public void AddTest2(int a, int b, int expectedTotal)
        {
            var actualTotal = calculator.add(a, b);
            Assert.Equal(expectedTotal, actualTotal);
        }
        [Theory]
        [InlineData(3,4,7)]
        public void add_simpleValues_returnTotalValue(int a , int b, int expectedTotal)
        {
            int actualTotal = calculator.Add(a, b);
            Assert.Equal(expectedTotal, actualTotal);
        }
        [Theory]
        [InlineData(0, 4, 0)]
        [InlineData(3, 0, 0)]
        public void add_zeroValues_returnZeroValue(int a, int b, int expectedTotal)
        {
            int actualTotal = calculator.Add(a, b);
            Assert.Equal(expectedTotal, actualTotal);
        }
    }
}
