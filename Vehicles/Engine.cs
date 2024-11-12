using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal abstract class Engine
    {
        public bool Running; public int Horsepower;

        public enum FuelTypes
        {
            Unleaded, Leaded, Diesel
        } public FuelTypes FuelType;

        public Engine(int Horsepower, FuelTypes ft)
        {
            this.Horsepower = Horsepower; this.FuelType = ft;
        }

        public void Start()
            { this.Running = true; }
    }
}
