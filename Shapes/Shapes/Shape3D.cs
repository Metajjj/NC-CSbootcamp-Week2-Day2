using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal abstract class Shape3D
    {
        public Shape BaseShape;
        public Shape3D(Shape shape) 
        { 
            this.BaseShape = shape;
        }

        public abstract double CalculateVolume();
    }
}
