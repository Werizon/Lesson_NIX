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
        public List<Person> users;
        private static ServicDB Db;


        private ServicDB()
        {
            testDrive = new List<Order>();
            preOrder = new List<Order>();
            buy = new List<Order>();
            cars = new List<PassagerCar>();
            users = new List<Person>();
        }

        public static ServicDB GetServicDB()
        {
            if (Db == null)
                Db = new ServicDB();
            return Db; 
        }

    }
}
