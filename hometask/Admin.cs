using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Admin: Person
    {
        //Класс админ, содержащий информацию о админе
        public int IdEmpl { get; set; }
        public ServicDB servicDb;

        public Admin(string name, string surname, int age, string phoneNumber, int idEmpl)
           : base(name, surname, age, phoneNumber)
        {
            IdEmpl = idEmpl;
            Role = StatusRole.Admin;
            servicDb = ServicDB.GetServicDB();
        }


        public override void UserInfo()
        {
            Console.WriteLine("Информация про пользователя (админ)");
            Console.WriteLine($"Name: { Name} \tSurname: { Surname} \tAge: { Age} " +
                $"\tPhone: { PhoneNumber} \tRole:{ Role} \tNumber Empl: { IdEmpl}");
        }

        public void ViewOrders()
        {

            foreach(var obj in servicDb.buy)
            {
                Console.WriteLine("\nПросмотр всех заказов:");
                Console.WriteLine($"Client: { obj.client.Name} \tAdmin: { obj.admin.Name} " +
                    $"\tCar: { obj.car.Brand} { obj.car.Model} \tDate: { obj.dateTime}"  );
            }
        }

        public void ViewOrder(int id)
        {
            Console.WriteLine("\nПросмотр заказа конкретного пользователя:");
            var res = servicDb.buy.Where(p => p.client.PasportId == id);
            foreach(var r in res)
                    Console.WriteLine($"Client: { r.client.Name} - id: { r.client.PasportId} " +
                        $"\tAdmin: { r.admin.Name} \tCar:  { r.car.Brand} { r.car.Model} \tDate: { r.dateTime} \tSuma: { r.car.Price}$");
        }

        public void ViewTestDrives()
        {
            Console.WriteLine("\nПросмотр всех записей на тест драйв:");
            foreach (var r in servicDb.testDrive)
                Console.WriteLine($"Client: { r.client.Name} - { r.client.PhoneNumber} " +
                    $"\tCar: { r.car.Brand} { r.car.Model} \tDate: { r.dateTime}");
        }
    }
}
