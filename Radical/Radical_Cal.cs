using System;

namespace Radical_Cal
{ 
    public static class Radical
    { 
        public static double FuncRadical(double chislo, double stepen)
        {
            double result = Math.Pow(chislo, 1 / stepen);
            return result;
        }
    }
}
