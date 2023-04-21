namespace Inheritance
{
    internal class Program
    {
        static List<Vehicle> vehicles = new List<Vehicle>(); //created a new vihicle list instance;
        static void Main(string[] args)
        {
            Vehicle vehicle = new Vehicle("Red"); //created a new instance for vehicle;
            Air air = new Air("Green"); //created a new instance for air;
            Helicopter helicopter = new Helicopter("Blue", 2); //created a new instance for helicopter;
            Plane plane = new Plane(3, "Pink"); //created a new instance for plane;
            Sea sea = new Sea("Orange", "Submarine"); //created a new instance for sea;
            Land land = new Land(4, "purple"); //created a new instance for land;

            vehicles.Add(vehicle); //add items in list;
            vehicles.Add(air);
            vehicles.Add(helicopter);
            vehicles.Add(plane);
            vehicles.Add(sea);
            vehicles.Add(land);
            
            foreach (Vehicle vehicles in vehicles) //use foreach to display each item;
            {
                Console.WriteLine(vehicles);
            }

        }
    }
}