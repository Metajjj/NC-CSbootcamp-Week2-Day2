using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Triangle :Shape
    {
        public double BaseLength, Height;

        public Triangle(double bl,double h) : base()
        {
            this.BaseLength = bl; this.Height = h;
        }

        public override Double CalculateArea()
        {
            return BaseLength * Height / 2;
        }
    }
}
