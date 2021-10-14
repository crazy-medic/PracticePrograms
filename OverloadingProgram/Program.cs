using System;

namespace OverloadingProgram
{
    class Program
    {
        static void Main(string[] args)
        {
            Overloading obj = new Overloading();
            int result1 = obj.Calculation(2, 3);
            int result2 = obj.Calculation(2, 3, 4);
            Console.WriteLine(result1);
            Console.WriteLine(result2);
        }
    }
}
