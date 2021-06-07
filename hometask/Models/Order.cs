using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Order
    {
        public static int Id = 0;
        public DateTime dateTime;
        public Client client;
        public Admin admin;
        public Auto car;

        public Order(Auto car, Client client, DateTime dateTime)
        {
            this.client = client;
            this.car = car;
            this.dateTime = dateTime;
        }

        public Order(Client client, Auto car, Admin admin, DateTime dateTime )
        {
            this.client = client;
            this.car = car;
            this.admin = admin;
            this.dateTime = dateTime;
        }

    }
}
