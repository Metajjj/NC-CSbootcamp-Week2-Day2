using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class CarEngine : Engine
    {
        public CarEngine(int horsePower=10, FuelTypes ft=FuelTypes.Diesel) : base(horsePower, ft)
        {

        }
    }
}
