using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.Lesson2
{
    public class Avto
    {
        public int Id { get; set; }
        public string Brand { get; set; }
        public string Model { get; set; }
        public string Body { get; set; }
        public string Color { get; set; }
        public int ReleaseYear { get; set; }
        public int LiftingCapacity { get; set; }
        public float Price { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Cart> Carts { get; set; }

        public Avto (string brand, string model, string body, string color, int releaseYear, int liftingCapacity, float price)
        {
            Brand = brand;
            Model = model;
            Body = body;
            Color = color;
            ReleaseYear = releaseYear;
            LiftingCapacity = liftingCapacity;
            Price = price;
        }


    }
}
