using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Test
{
    class Program
    {
        static void Main(string[] args)
        {
            int first = 3;
            string sValue = "Zack";

            ReturnMultiRef(ref first, ref sValue);


            Console.WriteLine($"{first}, {sValue}");

            Console.ReadKey();
        }

        static void ReturnMultiOut(out int i, out string s)
        {
            i = 25;
            s = "using out";
        }

        static void ReturnMultiRef(ref int i, ref string s)
        {
            i = 30;
            s = "using ref";
        }

    }
}
