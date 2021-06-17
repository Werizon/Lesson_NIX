﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{

    class PassagerCar : Auto, IAutoPass
    {
        //Класс автомобиль, содержащий свойства автомобиля,

        public string Body { get; set; }
        public string Color { get; set; }
        public int ReleasyYear { get; set; }
        public int MaxSpeed { get; set; }
        public string Description { get; set; }
        public double FuelConsumption { get; set; }
        public string TypeEngine { get; set; }
        public string TypeFuel { get; set; }
        Engine Engine { get; set; }


        public PassagerCar(string brand, string model, string body, string color, int year, int price,
            int maxSpeed, string desc, double fuelConsump, Engine engine)
        : base(brand, model, price)
        {
            Body = body;
            Color = color;
            ReleasyYear = year;
            MaxSpeed = maxSpeed;
            Description = desc;

            FuelConsumption = fuelConsump;
            Engine = engine;
        }

        public override void AutoInfo()
        {
            Console.WriteLine($"Информация про автомобиль: \nBrand: { Brand} \tModel: { Model} \tColor: { Color} \tYear: { ReleasyYear} " +
                $"\tPrice: { Price}$ \tMax speed: { MaxSpeed} ");
        }
    }
}
