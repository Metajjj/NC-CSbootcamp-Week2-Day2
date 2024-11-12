using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal class Motorcycle : Vehicles
    {
        public Boolean HasSidecar;
        public Motorcycle(Boolean HasSidecar, string make, string model): base(make, model,new CarEngine())
        {
            this.HasSidecar = HasSidecar;
        }

        protected override void Accelerate()
        {
            string message = $"{Make} {Model} speed: ";
            double fuelMod = EngineType.FuelType switch
            {
                Engine.FuelTypes.Unleaded => 1.5D,
                Engine.FuelTypes.Leaded => 1.2D,
                Engine.FuelTypes.Diesel => 1.8D,
                _ => throw new InvalidOperationException($"Unexpected value: {EngineType.FuelType}")
            };
            for (int i = 0; i < 10; i++)
            {
                Console.WriteLine($"{message}{((EngineType.Horsepower * fuelMod) * Math.Exp(Math.Sqrt(i)) / 2) * (HasSidecar ? 0.8 : 1.0)}mph");
            }
        }
    }
}
