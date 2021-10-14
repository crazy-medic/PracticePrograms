using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblem
{
    class Base
    {
        int a, b, c;
        
        public int Calculate(int a, int b)
        {
            c = a + b;
            return c;
        }
        public int Calculate(int a, int b, int c, int d)
        {
            return ((a + b) * (c - d));
        }
    }
}
