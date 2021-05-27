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
            servicDB.testDrive.Add(new Order(car, client, dateTime)); 
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

        public void AddUserToList (Client client)
        {
            servicDB.users.Add(client);
        }

        public void AddUserToList(Admin admin)
        {
            servicDB.users.Add(admin);
        }

        public void ViewUsers()
        {
            Console.WriteLine("..................");
            Console.WriteLine("Пользователи: ");
            foreach (var r in servicDB.users)
                Console.WriteLine($"\nName: { r.Name} \t Age: { r.Age} \tRole:{ r.Role} ");
            Console.WriteLine("...............................");
        }

         public void AddAutoToList(PassagerCar car)
        {
                servicDB.cars.Add(car);
        }

        public void ViewAvtos()
        {
            Console.WriteLine("...............................");
            Console.WriteLine("Автомобили в наличие: ");
            foreach (var r in servicDB.cars)
                Console.WriteLine($"\nBrand: { r.Brand} \tModel: { r.Model} " +
                    $"\tYear: { r.ReleasyYear} \tColor:{ r.Color} " +
                    $"\tMax speed { r.MaxSpeed} \tPrice: { r.Price}$ \tDesc: { r.Description}");
            Console.WriteLine("...............................");
        }

    }
}
