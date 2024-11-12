using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shapes
{
    internal class Sphere: Shape3D
    {
        
        public Sphere(Circle circle) : base(circle)
        {
            
        }

        public override double CalculateVolume()
        {
            //return Math.PI * Math.Pow((Radius), 2);
            //4 / 3 * Math.PI * ((Circle)BaseShape).Radius * Math.Pow(1, 1);
            return Math.Pow(5, 3) * Math.PI * (4 / 3);
            return 0d;
        }
    }
}
