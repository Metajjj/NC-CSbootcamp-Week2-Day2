using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class MotorcycleEngine : Engine
    {
        public MotorcycleEngine(int horsePower = 5, FuelTypes ft = FuelTypes.Unleaded) : base(horsePower, ft)
        {

        }
    }
}
