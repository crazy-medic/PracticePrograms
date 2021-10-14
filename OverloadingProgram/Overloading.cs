using System;
using System.Collections.Generic;
using System.Text;

namespace OverloadingProgram
{
    class Overloading
    {
        public int Calculation(int a, int b)
        {
            return a + b;
        }
        public int Calculation(int a,int b,int c)
        {
            return a + b + c;
        }
    }
}
