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
        public List<PassagerCar> cars;
        public List<Client> clients;
        public List<Admin> admins;
        private static ServicDB Db;


        private ServicDB()
        {
            testDrive = new List<Order>();
            preOrder = new List<Order>();
            buy = new List<Order>();
            cars = new List<PassagerCar>();
            clients = new List<Client>();
            admins = new List<Admin>();
        }

        public static ServicDB GetServicDB()
        {
            if (Db == null)
                Db = new ServicDB();
            return Db; 
        }

    }
}
