using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Pyramid : Shape3D
    {
        public double Height;
        public Pyramid(Triangle triangle, double height) : base(triangle)
        {
            this.Height = height;
        }

        public override double CalculateVolume()
        {
            return (BaseShape.CalculateArea() * Height) / 3;
            return 0d;
        }
    }
}
