using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Loops
{
    class Program
    {
        static void Main(string[] args)
        {
            for (int row = 0; row < 6; row++)
            {
                // Counting backwards here!
                for (int spaces = 5 - row; spaces > 0; spaces--)
                {
                    Console.Write(" ");
                }

                for (int column = 0; column < (2 * row + 1); column++)
                {
                    Console.Write("*");
                }

                Console.WriteLine();
            }
        }
    }
}
