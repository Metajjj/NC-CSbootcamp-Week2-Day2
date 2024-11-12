using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Rectangle :Shape
    {

        public double Width, Height;

        public Rectangle(double w,double h) : base()
        {
            this.Width = w; this.Height = h;
        }

        public override Double CalculateArea()
        {
            return Width * Height;
        }
    }
}
