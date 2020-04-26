using _08Homework.Enums;
using System;
using System.Collections.Generic;
using System.Text;

namespace _08Homework.Entities
{
    public class Car
    {
        public Car()
        {


        }
        public string Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Doors { get; set; }
        public int TopSpeed { get; set; }
        public Consumption CarConsumption { get; set; }
        public EngineType CarEngine { get; set; }

        public string GenerateID()
        {
            return Guid.NewGuid().ToString("N");
        }

        public void PrintInfo()
        {
            Console.WriteLine($"The car you have created has an ID number {Id}, from the brand {Brand}, model {Model}." +
                $" It has {Doors} doors, with a top speed of {TopSpeed}, the fuel consuption is {CarConsumption} and the engine is {CarEngine}.");
        }
    }
}
