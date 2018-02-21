using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Arrays
{
    class Program
    {
        static void Main(string[] args)
        {
            int[] scores;
            //setting scores array to a new integer array of length 10
            scores = new int[10];

            for (int i = 0; i < scores.Length; i++)
            {
                scores[i] = i;
            }

            foreach (var item in scores)
            {
                Console.WriteLine(item);
            }
        }  
    }
}
