using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Recursion
{
    class Program
    {
        static void Main(string[] args)
        {
            int factorial = 5;
            Console.WriteLine(Factorial(factorial));
        }


        static int Factorial(int num)
        {
            if (num == 0 || num == 1)
            {
                return 1;
            }
            return (num * Factorial(num - 1));
        }
    }
}
