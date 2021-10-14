using System;

namespace PracticeProblem
{
    class Program
    {
        static void Main(string[] args)
        {
            Derived obderived = new Derived();
            //Base ojbase = new Base();
            int result1 = obderived.Calculate(2, 3);
            int result2 = obderived.Calculate(2, 3);
            int result3 = obderived.Calculate(2, 3, 4, 5);
            Console.WriteLine("Base class calculation result is " + result1);
            Console.WriteLine("Derived class calculation result is " + result2);
            Console.WriteLine("Op from 4 parameter calc is " + result3);
        }
    }
}
