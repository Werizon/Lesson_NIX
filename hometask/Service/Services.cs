using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Services: IServices
    {
        public ServicDB servicDB;
 
        public Services()
        {
            servicDB = ServicDB.GetServicDB();
         }

        public void TestDrive(Auto car, Client client, DateTime dateTime) 
        {
            servicDB.testDrive.Add(new Order(car, client, dateTime)); 
        }

        public void PreOrder(Auto car, Client client, DateTime dateTime) 
        {
            servicDB.preOrder.Add(new Order(car, client, dateTime.Date));
        }

        public void Buy(Client client, Auto car, Admin admin)
        {
            try
            {
                if (client.discount <= 0)
                    client.discount = 1;
                car.Price -= ((car.Price / 100) * client.discount);
                servicDB.buy.Add(new Order(client, car, admin, DateTime.Now));
            }
            catch(Exception e) when (car == null || client == null || admin == null)
            {
                Console.WriteLine(e.Message);
            }
        }

        public void AddUserToList (Person user)
        {
            servicDB.users.Add(user);
        }

        public void ViewUsers()
        {
            Console.WriteLine("..................");
            Console.WriteLine("Пользователи: ");
            foreach (var r in servicDB.users)
                Console.WriteLine($"\nName: { r.Name} \t Age: { r.Age} \tRole:{ r.Role} ");
            Console.WriteLine("...............................");
        }

         public void AddAutoToList(Auto car)
        {
                servicDB.cars.Add(car);
        }

        public void ViewAvtos()
        {
            Console.WriteLine("...............................");
            Console.WriteLine("Автомобили в наличие: ");
            foreach (var r in servicDB.cars)
                Console.WriteLine($"\nBrand: { r.Brand} \tModel: { r.Model} " +
                    $"\tYear: { r.Price}");
            Console.WriteLine("...............................");
        }

    }
}
