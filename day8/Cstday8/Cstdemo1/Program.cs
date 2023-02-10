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
            //Staff sf1 = new Staff();
            //Person p1 = sf1;

            Staff st1 = new Staff();

            st1.StaffSpeak();
            st1.Speak();
            Console.ReadKey();

            Person p1 = new Person();
            p1.Speak();
            Console.ReadKey();
            Staff st2 = (Staff)p1;
            st2.StaffSpeak();





            //Person p1 = new Staff();

            //string str = string.Join("=", new string[] { "Tom", "Joey", "Alice", "Bob" });
            //Console.WriteLine(str);
            //Console.ReadLine();

        }
    }
}
