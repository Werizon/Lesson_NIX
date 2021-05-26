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

            PassagerCar nissanNX3 = new PassagerCar("Nissan", "NX-3", "Sedan", "Grey", 2020, 7000, 160, 8, 2.3, "Disel", "2WD", "Только из салона", 2 );
            
            Admin admin1 = new Admin("Stepan", "Taraskin", 20, "380954856831", 473753); // (данные о админе)
            Client client1 = new Client("Roman", "Horniy", 19, "380954856831", 2); // (данные о клиенте)
           
            Services services = new Services();

            admin1.UserInfo();

            
            client1.UserInfo();
            client1.DiscountInfo();

            DateTime dt = new DateTime(2042, 12, 24, 18, 42, 0);
            services.TestDrive(nissanNX3, client1, dt);

            services.Buy(client1, nissanNX3, admin1);

            nissanNX3.AutoInfo();

            admin1.ViewOrders();
            admin1.ViewOrder(client1.PasportId);

        }
    }
}
