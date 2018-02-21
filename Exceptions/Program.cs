using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Exceptions
{
    class Program
    {
        static void Main(string[] args)
        {
            List<string> names = new List<string>();
            string last = Console.ReadLine();
            Console.WriteLine(last);
   


        }

        static int TheirMoney(int myMoney, int yourMoney)
        {
            if (myMoney < 0 || yourMoney < 0) throw new ArithmeticException("My money or your money is not valid.");
            return myMoney + yourMoney;
        }

        static int OurMoney(int myMoney, int yourMoney)
        {
            if (myMoney < 0 || yourMoney < 0) throw new ArithmeticException("My money or your money is not valid.");
            return myMoney + yourMoney;
        }

        static void PrintName(string name)
        {
            Console.WriteLine(name);
        }
    }
}
