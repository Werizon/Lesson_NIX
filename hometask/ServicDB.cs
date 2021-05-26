using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class ServicDB
    {
        public List<Order> services;
        public List<Order> preOrder;
        public List<Order> buy;
     //   public ServicDB Db;


        public ServicDB()
        {
            services = new List<Order>();
            preOrder = new List<Order>();
            buy = new List<Order>();
        }

    }
}
