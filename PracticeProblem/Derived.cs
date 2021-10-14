using System;
using System.Collections.Generic;
using System.Text;

namespace PracticeProblem
{
    class Derived:Base
    {
        int a, b, c;

        public int Calculate(int a, int b)
        {
            c = a * b;
            return c;
        }
    }
}
