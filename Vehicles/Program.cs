namespace Vehicles
{
    internal class Program
    {
        static void Main(string[] args)
        {
            //Console.WriteLine("Hello, World!");

            List<Vehicles> vehicles = new List<Vehicles>{
                new Car("make1", "model1"),
                new Motorcycle(true, "make2", "model2")
            };

            foreach (var vehicle in vehicles)
            {
                Console.WriteLine("");
                vehicle.StartEngine(); vehicle.Drive();
                Console.WriteLine("");
            }
            


            Console.ReadKey();
        }
    }
}
