using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Services
    {
        public ServicDB servicDB;
 
        
        public Services()
        {
            servicDB = ServicDB.GetServicDB();
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
            car.Price -= ((car.Price / 100) * client.discount);
            servicDB.buy.Add(new Order(client, car, admin, DateTime.Now));
        }

    }
}
