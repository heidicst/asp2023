using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    class Program
    {
        static void Main(string[] args)
        {
            Cat cat = new Cat("Bob",20,"100");

           
            cat.Sayhello();
            cat.Move();
            cat.Speak();

            //cat.Sleeping();

            //cat.Eat();
            Console.ReadKey();

            Cat cat2 = new Cat("Tom", 12, "009");

            cat2.Sayhello();
            cat2.Move();
            cat2.Speak();
        }
    }
}
