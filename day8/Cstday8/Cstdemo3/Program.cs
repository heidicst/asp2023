using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo3
{
    class Program
    {
        static void Main(string[] args)
        {
            Shape shape = new Circle(11);

            Rectangle rectangle = new Rectangle(16, 22);

            double area= shape.GetArea();
            double perimeter=shape.GetPerimeter();

            Console.WriteLine("the shape of circle Area is\t{0:0.00},\t Perimeter is {1:0.00}",area,perimeter);

            Console.WriteLine("the shape of rectangle Area: " + rectangle.GetArea());

            Console.WriteLine("the shape of rectangle Perimeter: " + rectangle.GetPerimeter());

            Console.ReadLine();

        }
    }
}
