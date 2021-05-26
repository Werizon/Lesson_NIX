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

            PassagerCar nissan = new PassagerCar("Nissan", "NX-3", "Sedan", "Grey", 2020, 7000, 160, 8, 2.3, "Disel", "2WD", "Только из салона", 2 );
            
            Admin admin = new Admin("Stepan", "Taraskin", 20, "380954856831", 473753); // (данные о админе)
            Client client = new Client("Roman", "Horniy", 19, "380954856831", 2); // (данные о клиенте)
           
            ServicDB servicDB = new ServicDB();
            Services services = new Services(servicDB);


            admin.UserInfo();
        //    admin.ViewZakaz();
            
            client.UserInfo();
            client.DiscountInfo();

            DateTime dt = new DateTime(2042, 12, 24, 18, 42, 0);
            services.TestDrive(nissan, client, dt);

            services.Buy(client, nissan, admin);

            nissan.AutoInfo();

            admin.ViewOrders();
            services.ViewOrders();
        }
    }
}
