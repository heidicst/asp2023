using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo1
{
    class Staff:Person
    {
        public void StaffSpeak()
        {
            Console.WriteLine("this is child class of Staff");
        }
    }
}
