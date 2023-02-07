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
            // create object from class Person.

            Person p1 = new Person();
             p1._name = "Tom";
             p1._gender = "male";
             p1._age = 28;
             // call not static method
             p1.M1();
             Console.WriteLine("this is{0},gender :{1},I am {2}" ,p1._name,p1._gender,p1._age);
             Console.ReadKey();

            // this call static method
            //Person.M2();

            Person p2 = new Person();
            p2._name = "Alice";
            p2._gender = "Female";
            p2._age = -100;          
            Console.WriteLine("this is {0},gender{1} \t, I am {2}",p2._name,p2._gender,p2._age);
            Console.ReadKey();

          

        }
    }
}
