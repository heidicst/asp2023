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
            Bird bd1 = new Bird();
            bd1.Flying();
            Console.ReadKey();

            Plane p1 = new Plane();
            p1.Flying();
        }
    }
}
