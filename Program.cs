namespace Inheritance
{
    internal class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>();
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Red");
            Air air = new Air("Green");
            Helicopter helicopter = new Helicopter("Blue", 2);
            Plane plane = new Plane(3, "Pink");
            Sea sea = new Sea("Orange", "Submarine");
            Land land = new Land(4, "purple");

            vehicles.Add(vehicle);
            vehicles.Add(air);
            vehicles.Add(helicopter);
            vehicles.Add(plane);
            vehicles.Add(sea);
            vehicles.Add(land);
            
            foreach (Vehicle vehicles in vehicles)
            {
                Console.WriteLine(vehicles);
            }

        }
    }
}