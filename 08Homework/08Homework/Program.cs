using _08Homework.Entities;
using _08Homework.Enums;
using System;

namespace _08Homework
{
    
    class Program
    {
        static void Main(string[] args)
        {

            Car Volvo = new Car();
            Volvo.Id = Volvo.GenerateID();
            Volvo.Brand = "Volvo";
            Volvo.Model = "XC40";
            Volvo.Doors = 5;
            Volvo.TopSpeed = 270;
            Volvo.CarConsumption = Consumption.Economic;
            Volvo.CarEngine = EngineType.Electric;

            Volvo.PrintInfo();


            ElectricCar Audi = new ElectricCar();
            Audi.CarConsumption = Consumption.Medium;
            Console.WriteLine(Audi.BatteryCapacity);
            Audi.Drive(400);
            Console.WriteLine(Audi.BatteryCapacity);
            Audi.Recharge(800);

            FuelCar Ferrari = new FuelCar();
            Ferrari.CarConsumption = Consumption.High;
            Ferrari.CarEngine = EngineType.Petrol;
            Console.WriteLine(Ferrari.CurrentFuel);
            Ferrari.Drive(100);
            Console.WriteLine(Ferrari.CurrentFuel);
            Ferrari.Refuel(55);



            Console.WriteLine("SUP?");

            Console.ReadLine();
        }
    }
}
