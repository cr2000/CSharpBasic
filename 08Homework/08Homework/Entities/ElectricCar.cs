using _08Homework.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08Homework.Entities
{
    public class ElectricCar : Car
    {

        public ElectricCar()
        {
            CarEngine = EngineType.Electric;
            BatteryCapacity = 100;

        }

        public int BatteryCapacity { get; set; }
        public int BatteryUsage { get; set; }
        public void Drive(int distance)
        {
            BatteryUsage = (distance * (int)CarConsumption) / 10;
            Console.WriteLine($"The car used {BatteryUsage}% of the battery.");
            if (BatteryUsage < BatteryCapacity)
            {
                BatteryCapacity = BatteryCapacity - BatteryUsage;
                Console.WriteLine("The car will drive you there");
            }
            else
            {
                Console.WriteLine("There is not enough battery to go to the destination");
            }

        }

        public void Recharge(int minutes)
        {


            if ((minutes / 10) + BatteryCapacity <= 100)
            {
                BatteryCapacity = BatteryCapacity + (minutes / 10);
                Console.WriteLine($"The car is rechared {minutes / 10}% and now has {BatteryCapacity}%");
                return;

            }
            else
            {
                Console.WriteLine($"Can not charge longer than {(100 - BatteryCapacity) * 10} minutes");
            }
        }
    }
}
