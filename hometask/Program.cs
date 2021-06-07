using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Program
    {
         static void Main(string[] args)
        {

            Services services = new Services();

            PassagerCar nissanNX3 = new PassagerCar("Nissan", "NX-3", "Sedan", "Grey", 2020, 7000, 160, "2WD", "Только из салона" , 8, "Turbo 1.3", "Disel");
            PassagerCar opel = new PassagerCar("Opel", "Turbo", "Universal", "Black", 2000, 5000, 150, "2WD", "Только из салона", 7, "Class 3", "Benz");
            services.AddAutoToList(nissanNX3);
            services.AddAutoToList(opel);

            Admin admin1 = new Admin("Stepan", "Taraskin", 20, "380954856831", 473753); // (данные о админе)
            Client client1 = new Client("Roman", "Horniy", 19, "380954856831", 2); // (данные о клиенте)
            Client client2 = new Client("Kolyan", "Letty", 23, "380123345653", 4);

            //добавление пользователя и админа в список


            services.AddUserToList(client1);
            services.AddUserToList(client2);
            services.AddUserToList(admin1);
            services.ViewUsers();   //  просмотр всех пользователей

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
