using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Order
    {
        public static int Id { get; set; }
        public DateTime dateTime;
        public Client client;
        public Admin admin;
        public PassagerCar car;
        public Services services;

        public List<Order> orders;
        
        public Order(PassagerCar car, Client client, DateTime dateTime)
        {
            this.client = client;
            this.car = car;
            this.dateTime = dateTime;
        }


        public void Buy(Client client, Admin admin, PassagerCar car)
        {
                //Order order = new Order();
                //Id += 1;
                //order.client = client;
                //order.admin = admin;
                //order.car = car;
                //order.van = van;
                //orders.Add(order);
        }
        public void ViewOrder(int id) // просмотреть заказ
        {
            
        }
    }
}
