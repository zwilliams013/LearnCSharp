using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Classes
{   
    class Person
    {

        public string name;
        private int age;
        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }
    }

    class Program
    {

        static void Main(string[] args)
        {
            int a = 3;
            int b = 3;
            int c = 3;
            Person zack = new Person("Zack", 22);
            Console.WriteLine(zack.name);
            Console.ReadLine();


        }
    }
}
