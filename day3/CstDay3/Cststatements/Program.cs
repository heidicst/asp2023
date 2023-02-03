using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cststatements
{
    class Program
    {
        static void Main(string[] args)
        {

            Console.WriteLine("please enter one integer number");
            int nums =Convert.ToInt32(Console.ReadLine());
            if (nums%2==0)
            {
                Console.WriteLine("the number is even");
                Console.ReadLine();
            }

            else
            {
                Console.WriteLine("the number is odd");
                Console.ReadLine();
            }
        }
    }
}
