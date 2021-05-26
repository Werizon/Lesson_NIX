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
        private static ServicDB Db;

        private ServicDB()
        {
            services = new List<Order>();
            preOrder = new List<Order>();
            buy = new List<Order>();
        }

        public static ServicDB GetServicDB()
        {
            if (Db == null)
                Db = new ServicDB();
            return Db; 
        }

    }
}
