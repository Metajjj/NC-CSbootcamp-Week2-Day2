using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Prism : Shape3D
    {
        public double Height;
        
        public Prism(Triangle triangle, double height) : base(triangle)
        {
            this.Height = height;
           
        }

        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height;
            return 0d;
        }
    }
}
