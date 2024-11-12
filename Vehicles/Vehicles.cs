using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Vehicles
{
    internal abstract class Vehicles
    {
        public string Make, Model; public int Speed;

        public Engine EngineType;

        public Vehicles(string make, string model, Engine engineType) 
        {
            this.Make = make;
            this.Model = model;
            this.EngineType = engineType;
        }

        public void StartEngine()
        {
            EngineType.Start();
        }

        public void Drive()
        {
            if(EngineType.Running)
            {
                Accelerate();

                return;
            }
            Console.WriteLine($"{Make} {Model} is not running.");

        }

        protected abstract void Accelerate();
        
        
    }
}
