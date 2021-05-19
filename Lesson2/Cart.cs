using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.Lesson2
{
    public class Cart
    {
        public int CartId { get; set; }
        public int AvtoId { get; set; }
        public int UserOrderId { get; set; }
        public string StatusCart { get; set; }

        public Avto avto { get; set; }
        public Order Order { get; set; }
    }
}
