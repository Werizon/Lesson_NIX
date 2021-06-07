using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    abstract class Auto
    {
        //Абстрактный класс с основными свойствами и методами, необходимыми для работы с товаром
 
        public static int Id = 0;
        public int NumbId { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public int Price { get; set; }    
     

        public Auto(string brand, string model, int price)
        {
            Id++;
            NumbId = Id;
            Brand = brand;
            Model = model;
            Price = price;
        }

        public virtual void AutoInfo() 
        {
            Console.WriteLine($"{ Brand} \t { Model} \t { Price}");
        }

    }
}
