using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{

    // https://habr.com/ru/post/345658/ по ООП
    class PassagerCar : TransportDrawing
    {
        //Класс автомобиль, содержащий свойства автомобиля,
        public int CountDoor { get; set; } = 4;
        public PassagerCar(string brand, string model, string body, string color, int year, int price, int maxSpeed,
            double fuelConsumption, double vEngine, string typeFuel, string typeDrive, string desc, int countDoor)
        : base(brand, model, body, color, year, price, maxSpeed, fuelConsumption,
              vEngine, typeFuel, typeDrive, desc)
        {
            CountDoor = countDoor;
        }

        public override void AutoInfo()
        {
            Console.WriteLine($"Brand: { Brand} \tModel: { Model} \tColor: { Color} \tYear: {ReleasyYear} " +
                $"\tPrice: {Price} \tMax speed: {MaxSpeed}");
        }
    }
}
