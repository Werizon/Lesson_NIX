using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    abstract class TransportDrawing: TransportRequirements
    {
        //Абстрактный класс с основными свойствами и методами, необходимыми для работы с товаром
        public int Id;
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Body { get; set; }
        public string Color { get; set; }
        public string Country { get; set; }
        public string LiftingCapacity { get; set; }
        public int ReleasyYear { get; set; }
        public string Price { get; set; }    
        public int MaxSpeed { get; set; }
        public float FuelConsumption { get; set; }
        public string TypeEngine { get; set; }
        public string TypeFuel { get; set; }

        public TransportDrawing() { }
        public TransportDrawing(string brand, string model, string body, string color, string country, 
            string liftingCapacity, int releasyYear, string price, int maxSpeed, float fuelConsumption,
            string typeEngine, string typeFuel)
        {
            Brand = brand;
            Model = model;
            Body = body;
            Color = color;
            Country = country;
            LiftingCapacity = liftingCapacity;
            ReleasyYear = releasyYear;
            Price = price;
            MaxSpeed = maxSpeed;
            FuelConsumption = fuelConsumption;
            TypeEngine = typeEngine;
            TypeFuel = typeFuel;
        }

    }
}
