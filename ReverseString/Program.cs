using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Diagnostics;
using System.Threading.Tasks;

namespace ReverseString
{
    class Program
    {
        private static Random random = new Random((int)DateTime.Now.Ticks);
        private static Stopwatch stop = new Stopwatch();

        static void Main(string[] args)
        {

            /*
            #region MyRegion
            string inputString = "one two three four five";
            string outputString = string.Join(" ", inputString
                .Split(' ')
                .Select(x => new string(x.Reverse().ToArray())));

            Console.WriteLine(outputString);
            Console.ReadLine();
            #endregion 
            */

            string word = "za ck";
            string reverse = "";
            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += (char)word[i];
            }
            Console.WriteLine(reverse);
   
            Console.ReadKey();
            
        }

        static string randomString(int size)
        {
            
            StringBuilder sb = new StringBuilder();
            char ch;

            for (int i = 0; i < size; i++)
            {
                ch = Convert.ToChar(Convert.ToUInt32(26 * random.NextDouble() + 65));
                sb.Append(ch);
            }

            return sb.ToString();
        }

        public void regReverse(string word)
        {
            string reverse = "";

            for (int i = word.Length - 1; i >= 0; i--)
            {
                reverse += word[i];
            }

            Console.WriteLine(reverse);
            Console.ReadLine();
        }

        static void sbReverse(string word)
        {
            StringBuilder sb = new StringBuilder();

            for (int i = word.Length - 1; i >= 0; i--)
            {
                sb.Append(word[i]);
            }

            Console.WriteLine(sb.ToString());
        }
    }
}
