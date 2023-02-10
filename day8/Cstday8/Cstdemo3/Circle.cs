using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Cstdemo3
{
    public class Circle:Shape
    {
        private double _radius;

        public double Radius
        {
            get { return _radius; }
            set { _radius = value; }
        }

        // constructor

        public Circle(double radius)
        {
            this.Radius = radius;
        }

        public override double GetArea()
        {
            return Math.PI * this.Radius * this.Radius;
        }

        public override double GetPerimeter()
        {
            return Math.PI * 2 * this.Radius;
        }
    }
}
