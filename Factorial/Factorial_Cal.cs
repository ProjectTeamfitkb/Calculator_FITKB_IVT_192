using System;

namespace Factorial_Cal
{
    public class Factorial
    {
        public static double FuncFactorial(double x)
        {
            if (x <= 1)
            {
                return 1;
            }
            else
            {
                double result = x * FuncFactorial(x - 1);
                return result;
            }
        }

    }
}
