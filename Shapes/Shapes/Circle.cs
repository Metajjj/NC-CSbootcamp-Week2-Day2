using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Circle : Shape
    {
        public double Radius;

        public Circle(double r) :base()
        { 
            this.Radius = r;
        }

        public override Double CalculateArea()
        {
            return
                //Math.Round(
                Math.PI * Math.Pow((Radius), 2);
                //, 2);
        }
    }
}
