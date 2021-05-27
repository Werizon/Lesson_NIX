using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Program
    {
         static void Main(string[] args)
        {
            // Auto //(данные о автомобиле)

            Services services = new Services();

            PassagerCar nissanNX3 = new PassagerCar("Nissan", "NX-3", "Sedan", "Grey", 2020, 7000, 160, 8, 2.3, "Disel", "2WD", "Только из салона", 2 );
            PassagerCar opel = new PassagerCar("Opel", "Turbo", "Universal", "Black", 2000, 5000, 150, 7, 1.8, "Benz", "2WD", "Только из салона", 2);
            services.AddAutoToList(nissanNX3);
            services.AddAutoToList(opel);

            Admin admin1 = new Admin("Stepan", "Taraskin", 20, "380954856831", 473753); // (данные о админе)
            Client client1 = new Client("Roman", "Horniy", 19, "380954856831", 2); // (данные о клиенте)
           
          
            admin1.UserInfo();  // просмотр инф об админе

            client1.UserInfo(); // просмотр инф об пользователе
            client1.DiscountInfo(); // просмотр информации про скидку

            services.ViewAvtos();   // просмотр всех авто

            DateTime dt = new DateTime(2042, 12, 24, 18, 42, 0);
            services.TestDrive(nissanNX3, client1, dt); // запись на тест-драйв

            services.Buy(client1, nissanNX3, admin1);

            nissanNX3.AutoInfo();   // просмотр инф об автомобиле

            admin1.ViewOrders();    // просмотр всех заказов
            admin1.ViewOrder(client1.PasportId);    // просмотр заказов конкретного пользователя
            admin1.ViewTestDrives();    // просмотр всех записей тест-драйва


        }
    }
}
