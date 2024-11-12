using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Cone : Shape3D
    {
        public double Height;
        //public Shape shape;
        public Cone(Circle circle, double height) : base(circle)
        {
            this.Height = height;
            //this.shape = shape;
        }

        public override double CalculateVolume()
        {
            return (BaseShape.CalculateArea() * Height)/3;
            return 0d;
        }
    }
}
