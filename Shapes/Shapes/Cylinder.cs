using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Cylinder : Shape3D
    {
        public double Height;
        //public Shape shape;
        public Cylinder(Circle circle,double height) :base(circle)
        { 
            this.Height = height;
            //this.shape = circle;
            //CalculateVolume();
        }

        public override double CalculateVolume()
        {
            return BaseShape.CalculateArea() * Height;
            return 0d;
        }
    }
}
