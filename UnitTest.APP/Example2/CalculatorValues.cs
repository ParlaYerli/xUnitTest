using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.APP.Example2
{
    public class CalculatorValues
    {
        private ICalculatorService calculatorService;
        public CalculatorValues(ICalculatorService calculatorService)
        {
            this.calculatorService = calculatorService;
        }

        public int add(int a ,int b)
        {
            return calculatorService.add(a, b);
        }

        public int multip(int a, int b)
        {
            if (a==0)
            {
                throw new Exception("a=0 olamaz!");
            }
            return calculatorService.multip(a, b);
        }
    }
}
