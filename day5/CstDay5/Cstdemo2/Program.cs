﻿using System;
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
            // create object from class Person.

            Person p1 = new Person();
            p1._name = "Tom";
            p1._gender = "male";
            p1._age = 28;
            // call not static method
            p1.M1();
            Console.WriteLine("this is{0},gender :{1}, I am {2}" ,p1._name,p1._gender,p1._age);
            Console.ReadKey();

            // this call static method
            // Person.M2();

            Person p2 = new Person();
            p2._name = "Alice";
            p2._gender = "Female";
            p2._age = -100;
            Console.WriteLine("this is {0}, gender\t{1} \t, I am {2}",p2._name,p2._gender,p2._age);
            Console.ReadKey();

            Person p3 = new Person();
            p3._name = "Bob";
            p3._gender = "male";
            p3._age = 210;
            Console.WriteLine("this is {0}, gender\t{1} \t, I am {2}", p3._name, p3._gender,p3._age);
            Console.ReadKey();




        }
    }
}
