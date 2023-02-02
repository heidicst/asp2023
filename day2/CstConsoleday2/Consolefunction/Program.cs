using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Consolefunction
{
    class Program
    {
        static void Main(string[] args)
        {


            //SayHello();
            //Console.ReadKey();


            //void SayHello()
            //{
            //    Console.WriteLine("Welcome to CST college.!!");
            //}

            string mystr = "Tom";
            string resultStr;

            resultStr= SayHello(mystr);
            Console.WriteLine(resultStr);

            Console.WriteLine(SayHello());
            Console.ReadLine();


// define a method
            string SayHello(string str="Joy") 
            {

                string message="Welcome to CST college:" + str;
                return message;
            }

        }
    }
  }
