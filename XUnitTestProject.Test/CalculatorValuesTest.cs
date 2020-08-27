using Moq;
using System;
using System.Collections.Generic;
using System.Text;
using UnitTest.APP.Example2;
using Xunit;

namespace XUnitTestProject.Test
{
    public class CalculatorValuesTest
    { 
        public CalculatorValues calculatorValues { get; set; }
        public Mock<ICalculatorService> mymock { get; set; }
        public CalculatorValuesTest()
        {
            mymock = new Mock<ICalculatorService>();
            this.calculatorValues = new CalculatorValues(mymock.Object);
        }
        [Theory]
        [InlineData(2,8,10)]
        public void Add_simpleValues_ReturnTotalValue(int a,int b, int expectedTotal)
        {
            mymock.Setup(x => x.add(a, b)).Returns(expectedTotal);
            var actualTotal = calculatorValues.add(a, b);
            Assert.Equal(expectedTotal, actualTotal);
        }
        [Theory]
        [InlineData(2, 8, 16)]
        public void Multip_simpleValues_ReturnTotalValues(int a,int b,int exmpectedTotal)
        {
            mymock.Setup(x => x.multip(a, b)).Returns(exmpectedTotal);
            var actualTotal = calculatorValues.multip(a, b);
            Assert.Equal(exmpectedTotal, actualTotal);
        }
    }
}
