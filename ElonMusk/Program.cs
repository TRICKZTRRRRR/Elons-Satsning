using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElonMusk
{
    internal class Program
    {
        static void Main(string[] args)
        {
            // Car 1
            Console.WriteLine("\nCar 1");
            Console.Write("Initial distance driven (meters): ");
            int car1DistanceDriven = int.Parse(Console.ReadLine());
            Console.Write("Color: ");
            string car1Color = Console.ReadLine();

            // Car 2
            Console.WriteLine("\nCar 2");
            Console.Write("Initial distance driven (meters): ");
            int car2DistanceDriven = int.Parse(Console.ReadLine());
            Console.Write("Color: ");
            string car2Color = Console.ReadLine();

            RCCar car1 = new RCCar(car1DistanceDriven, car1Color);
            RCCar car2 = new RCCar(car2DistanceDriven, car2Color);

            // Test driving the cars
            car1.Drive(30); // Drive car1 for 30 meters
            car2.Drive(50); // Drive car2 for 50 meters

            // Recharge the cars
            car1.Recharge();
            car2.Recharge();

            Console.ReadLine(); // Wait for user input before exiting
        }
    }
}
