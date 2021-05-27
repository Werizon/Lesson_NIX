using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class ServicDB
    {
        public List<Order> testDrive;
        public List<Order> preOrder;
        public List<Order> buy;
        public List<Order> cars;
        public List<Order> clients;
        public List<Order> admins;
        private static ServicDB Db;


        private ServicDB()
        {
            testDrive = new List<Order>();
            preOrder = new List<Order>();
            buy = new List<Order>();
            cars = new List<Order>();
            clients = new List<Order>();
            admins = new List<Order>();
        }

        public static ServicDB GetServicDB()
        {
            if (Db == null)
                Db = new ServicDB();
            return Db; 
        }

    }
}
