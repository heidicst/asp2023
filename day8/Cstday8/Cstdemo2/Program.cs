using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo2
{
    class Program
    {
        static void Main(string[] args)
        {
            //Animal[] animal = {
            //new Cat(),
            //new Dog()
            //};

            //foreach (Animal aa in animal)
            //{
            //    aa.Speak();
            //}
            Animal animal1 = new Cat();

            //cat1 = new Cat();
            //Animal animal1 = cat1;

            Animal animal2 = new Dog();

            animal1.Speak();
            animal2.Speak();

            Console.ReadKey();
        }
    }
}
