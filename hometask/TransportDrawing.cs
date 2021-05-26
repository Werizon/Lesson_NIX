using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    abstract class TransportDrawing
    {
        //Абстрактный класс с основными свойствами и методами, необходимыми для работы с товаром
        public static int Id = 0;
        public int NumbId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Body { get; set; }
        public string Color { get; set; }
        public int ReleasyYear { get; set; }
        public int Price { get; set; }    
        public int MaxSpeed { get; set; }
        public double FuelConsumption { get; set; }
        public double VEngine { get; set; }
        public string TypeFuel { get; set; }
        public string TypeDrive { get; set; }
        public string Description { get; set; }

        public TransportDrawing(string brand, string model, string body, string color,
            int releasyYear, int price, int maxSpeed, double fuelConsumption,
            double vEngine, string typeFuel, string typeDrive, string desc)
        {
            Id++;
            NumbId = Id;
            Brand = brand;
            Model = model;
            Body = body;
            Color = color;
            ReleasyYear = releasyYear;
            Price = price;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            VEngine = vEngine;
            TypeFuel = typeFuel;
            TypeDrive = typeDrive;
            Description = desc;
        }

        public abstract void AutoInfo();

    }
}
