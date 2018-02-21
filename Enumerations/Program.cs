using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Enumerations
{
    public enum DaysOfTheWeek
    {
        Sunday, Monday, Tuesday, Wednesday, Thursday, Friday, Saturday
    };

    class Program
    {
        static void Main(string[] args)
        {
            DaysOfTheWeek today;
            today = DaysOfTheWeek.Friday;
            int dayAsInt = (int)DaysOfTheWeek.Friday;
            Console.WriteLine(dayAsInt);

        }
    }
}
