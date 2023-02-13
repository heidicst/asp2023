using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace CstDemo2
{
    class Rectangle : IPolygon, IColor
    {
        public Rectangle()
        {
        }

        void CalcuateArea(int a, int b)
        {
            Console.WriteLine("The Area of Rectangle is {0}", a * b);
        }
        public void GetColor()
        {
            Console.WriteLine("the color if Rectangel is blue");
        }
    }
}
