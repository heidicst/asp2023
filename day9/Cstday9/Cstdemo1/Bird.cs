using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    public class Bird:IFlyable, ITaxcau
    {
        public void Flying()
        {
            Console.WriteLine("I am bird, I am flying");
        }
       
        public void Taxcalculator()
        {
            Console.WriteLine("This is Tax calucator of bird");
        }            
    }
}
