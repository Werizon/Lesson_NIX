using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask.Models
{
    class JeepCar : Auto, IAutoPass, IEngine
    {
        public string Body { get; set; }
        public string Color { get; set; }
        public int ReleasyYear { get; set; }
        public string TypeDrive { get; set; }
        public int MaxSpeed { get; set; }
        public string TypeEngine { get; set; }
        public string TypeFuel { get; set; }
        public string Complect {get; set;}
        public string Description { get; set; }
        public double FuelConsumption { get; set; }

        public JeepCar(string brand, string model, string body, string color, int year, int price,
           int maxSpeed, string typeDrive, string desc, double fuelConsump, string typeEngine, string typeFuel, string complect)
       : base(brand, model, price)
        {
            Body = body;
            Color = color;
            ReleasyYear = year;
            MaxSpeed = maxSpeed;
            TypeDrive = typeDrive;
            Description = desc;
            TypeDrive = typeDrive;
            TypeEngine = typeEngine;
            TypeFuel = typeFuel;
            FuelConsumption = fuelConsump;
            Complect = complect;
        }

        public override void AutoInfo()
        {
            Console.WriteLine($"Информация про автомобиль: \nBrand: { Brand} \tModel: { Model} \tColor: { Color} \tYear: { ReleasyYear} " +
                $"\tPrice: { Price}$ \tComplect: { Complect} ");
        }
    }
}
