using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.Lesson2
{
    public class Order
    {
        public int AvtoId { get; set; }
        public int UserId { get; set; }
        public int Count { get; set; }
        public float Price { get; set; }
        public User User { get; set; }
        public Avto avto { get; set; }

        public Order(int count, float price)
        {
            Count = count;
            Price = price;
        }

    }
}
