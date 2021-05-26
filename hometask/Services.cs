using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Services
    {
          public ServicDB servicDB;
     //   public List<Services> services;
     //   public List<Services> preOrder;

        public Services(ServicDB servicDB)
        {
            this.servicDB = servicDB;
        //    ServicDB servic = new ServicDB();
        }

        public void TestDrive(PassagerCar car, Client client, DateTime dateTime) 
        {
            servicDB.services.Add(new Order(car, client, dateTime)); 
        }

        public void PreOrder(PassagerCar car, Client client, DateTime dateTime) 
        {
            servicDB.preOrder.Add(new Order(car, client, dateTime.Date));
        }

        public void Buy(Client client, PassagerCar car, Admin admin)
        {
            servicDB.buy.Add(new Order(client, car, admin, DateTime.Now));
        }
    }
}
