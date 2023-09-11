using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ElonMusk
{
    #region Model
    public class RCCar
    {
        private sbyte batteryCapacity;
        private int distanceDriven;
        private sbyte batteryLife;
        private string color;

        public sbyte BatteryCapacity
        {
            get { return batteryCapacity; }
            set { batteryCapacity = value; }
        }

        public int DistanceDriven
        {
            get { return distanceDriven; }
            private set { distanceDriven = value; }
        }

        public sbyte BatteryLife
        {
            get { return batteryLife; }
            private set { batteryLife = value; }
        }

        public string Color
        {
            get { return color; }
            private set { color = value; }
        }

        public RCCar(int initialDistanceDriven, string carColor)
        {
            BatteryCapacity = 100;
            DistanceDriven = initialDistanceDriven;
            BatteryLife = BatteryCapacity;
            Color = carColor;
        }

        public void Drive(int meters)
        {
            if (BatteryLife > 0)
            {
                int metersDriven = Math.Min(meters, BatteryLife * 20); // Ensure we don't drive more than the available battery allows
                DistanceDriven += metersDriven;
                int batteryDrain = metersDriven / 20; // Calculate the battery drain
                BatteryLife -= (sbyte)batteryDrain;
                UpdateDisplay();
            }
            else
            {
                Console.WriteLine("The car is out of battery and cannot drive.");
                Console.ReadLine();

            }
        }

        public void Recharge()
        {
            DistanceDriven = 0;
            BatteryLife = BatteryCapacity;
            UpdateDisplay();
        }

        private void UpdateDisplay()
        {
            Console.WriteLine($"\nCar Color: {Color}");
            Console.WriteLine($"Distance Driven: {DistanceDriven} meters");
            Console.WriteLine($"Battery Life: {BatteryLife}%");
            Console.ReadLine();
        }
    }
    #endregion
}
