using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ModuleLibrary
{
    public static class Class1
    {
        public static double Module(double variable_first)
        { if (variable_first > 0)
                return variable_first;
            else return variable_first * -1;
        }
    }
}
