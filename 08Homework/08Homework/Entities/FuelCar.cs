using _08Homework.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08Homework.Entities
{
    public class FuelCar : Car
    {
        public FuelCar()
        {
            CarEngine = EngineType.Petrol;
            FuelCapacity = 100;
            CurrentFuel = 40;
        }

        public int FuelCapacity { get; set; }
        public int CurrentFuel { get; set; }
        public void Drive(int distance)
        {
            int FuelUsed = distance * (int)CarConsumption / 10;
            Console.WriteLine($"The car has used {FuelUsed} units of fuel.");
            if (CurrentFuel > FuelUsed)
            {
                CurrentFuel = CurrentFuel - FuelUsed;
                Console.WriteLine("The car will drive you there");
            }
            else
            {
                Console.WriteLine("There is not enough fuel to go to the destination");
            }


        }
        public void Refuel(int fuel)
        {
            if (CurrentFuel + fuel > 100)
            {

                Console.WriteLine("You will exeed tank capacity, please put less fuel");
            }
            else
            {
                CurrentFuel += fuel;
                Console.WriteLine($"You have added {fuel} units of fuel, and now the car has {CurrentFuel} units of fuel.");
            }
        }

    }
}
