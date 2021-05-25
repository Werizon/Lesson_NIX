using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class ServicDB
    {
        public List<Order> services;
        public List<Order> preOrder;

        public ServicDB()
        {
            services = new List<Order>();
            preOrder = new List<Order>();
        }       

    }
}
