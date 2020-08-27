using System;
using System.Collections.Generic;
using System.Text;

namespace UnitTest.APP.Example2
{
    public class CalculatorService : ICalculatorService
    {
        public int add(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            return a + b;
        }
    
     public int multip(int a, int b)
        {
            if (a == 0 || b == 0)
            {
                return 0;
            }
            return a + b;
        }
    }
}
