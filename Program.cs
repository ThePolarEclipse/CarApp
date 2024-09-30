using System;

namespace CarApp
{
    class Program
    {
        static void Main(string[] args)
        {
            // Create a 1970 Dodge Challenger object with color purple
            Car myCar = new Car("Dodge", "Challenger", "IP70 DGE", 1970, 50000.00m, "Purple");

            // Print the car's details
            Console.WriteLine("\nCar Details:");
            Console.WriteLine(myCar.ToString());

            // Print the car's details in a list format
            Console.WriteLine("\nDetails List:");
            Console.WriteLine($"Value of the Car: ${myCar.GetCurrentValue()}");
            Console.WriteLine($"Year of the Car: {myCar.GetYear()}");
            Console.WriteLine($"Color of the Car: {myCar.GetColor()}");
            Console.WriteLine($"Make of the Car: {myCar.GetMake()}");
            Console.WriteLine($"Model of the Car: {myCar.GetModel()}");
            Console.WriteLine($"Registration of the Car: {myCar.GetRegistration()}");
        }
    }
}
