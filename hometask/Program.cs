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

            admin.UserInfo();
            admin.ViewZakaz();
            
            client.UserInfo();
            client.DiscountInfo();

            Services.TestDrive(nissan, 05.10, 2021);
          //  client.TestDrive(nissan, 05.10,2021);

            Services.ZakazAvto(nissan);
            Services.ViewAuto();
            admin.ViewAuto();

            nissan.AutoInfo();
        }
    }
}
