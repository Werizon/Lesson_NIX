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
            servicDB.clients.Add(new Order(client));
        }

        public void AddUserToList(Admin admin)
        {
            servicDB.admins.Add(new Order(admin));
        }

        public void ViewUsers()
        {
            Console.WriteLine("..................");
            Console.WriteLine("Пользователи: ");
            foreach (var r in servicDB.admins)
                Console.WriteLine($"\nName: { r.admin.Name} \t Age: { r.admin.Age} \tRole:{ r.admin.Role} \tNumber admin: { r.admin.IdEmpl} ");
            foreach (var r in servicDB.clients)
                Console.WriteLine($"Name: { r.client.Name} \t Age: { r.client.Age} \tRole: { r.client.Role} ");
            Console.WriteLine("...............................");
        }

        //public Services(PassagerCar car)
        //{
        //    this.car = car;
        //}
        //PassagerCar car;
        public void AddAutoToList(PassagerCar car)
        {
                servicDB.cars.Add(new Order(car));
        }

        public void ViewAvtos()
        {
            Console.WriteLine("...............................");
            Console.WriteLine("Автомобили в наличие: ");
            foreach (var r in servicDB.cars)
                Console.WriteLine($"\nBrand: { r.car.Brand} \tModel: { r.car.Model} " +
                    $"\tYear: { r.car.ReleasyYear} \tColor:{ r.car.Color} " +
                    $"\tMax speed { r.car.MaxSpeed} \tPrice: { r.car.Price}$ \tDesc: { r.car.Description}");
            Console.WriteLine("...............................");
        }

    }
}
