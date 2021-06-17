using Lesson_NIX_2.hometask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Threading;
using System.Threading.Tasks;
using System.Xml.Serialization;

namespace Lesson_NIX_2.hometask
{
    class Program
    {

        static async Task Main(string[] args)
        {

            Services services = new Services();

            PassagerCar nissanNX3 = new PassagerCar("Nissan", "NX-3", "Sedan", "Grey", 2020, 7000, 160, "Только из салона", 8, new Engine("Turbo 1.3", "Hibrid"));
            PassagerCar opel = new PassagerCar("Opel", "Turbo", "Universal", "Black", 2000, 5000, 150, "Только из салона", 7, new Engine("Vtype", "Disel"));
            JeepCar jeep = new JeepCar("Jeep", "Kundro", "Pikap", "Dark Green", 2015, 6500, 140, "4WD", "Описание джипа", 10.5, new Engine("Nadd34", "Benzin"), "Комфорт");


            services.AddAutoToList(nissanNX3);
            services.AddAutoToList(opel);
            services.AddAutoToList(jeep);

            Admin admin1 = new Admin("Stepan", "Taraskin", 20, "380954856831", 473753); // (данные о админе)
            Client client1 = new Client("Roman", "Horniy", 19, "380954856831", 2); // (данные о клиенте)
            Client client2 = new Client("Kolyan", "Letty", 23, "380123345653", 4);


            //добавление пользователя и админа в список

            services.AddUserToList(client1);
            services.AddUserToList(client2);
            services.AddUserToList(admin1);
            //services.ViewUsers();   //  просмотр всех пользователей

            //admin1.UserInfo();  // просмотр инф об админе

            //client1.UserInfo(); // просмотр инф об пользователе
            //client1.DiscountInfo(); // просмотр информации про скидку

            //services.ViewAvtos();   // просмотр всех авто

            DateTime dt = new DateTime(2042, 12, 24, 18, 42, 0);
            services.TestDrive(nissanNX3, client1, dt); // запись на тест-драйв

            services.Buy(client1, nissanNX3, admin1);

            //nissanNX3.AutoInfo();   // просмотр инф об автомобиле

            //admin1.ViewOrders();    // просмотр всех заказов
            //admin1.ViewOrder(client1.PasportId);    // просмотр заказов конкретного пользователя
            //admin1.ViewTestDrives();    // просмотр всех записей тест-драйва


            List<Client> clients = new List<Client>
            {
                new Client("Roman", "Horniy", 19, "380954856831", 2),
                new Client("Kolyan", "Letty", 23, "380123345653", 4),
                new Client("Nikita", "Terok", 25, "380955746380", 5),
            };

            try
            {
                SaveDataAsync(clients);
                List<Client> clients1 = await GetDataAsync();
                
                foreach (var obj in clients1)
                {
                    Console.WriteLine(obj.Surname.ToString());
                }
            }
            catch(Exception e)
            {
                Console.WriteLine(e.Message);
            }
            finally
            {
                Console.WriteLine("The END");
            }
           
        }

      
        public async static void SaveDataAsync(List<Client> clients)
        {
            Console.WriteLine("Save async");
            await Task.Run(() => SaveDataAs(clients));
            Console.WriteLine("End save async");
        }

        public static async Task<List<Client>> GetDataAsync()
        {
            return await Task.Run(() => GetData());
        }

        public static void SaveDataAs(List<Client> clients)
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
            using (FileStream stream = new FileStream("clients.xml", FileMode.OpenOrCreate))
            {
                serializer.Serialize(stream, clients);
            }
        }

        public static List<Client> GetData()
        {
            XmlSerializer serializer = new XmlSerializer(typeof(List<Client>));
            Thread.Sleep(1500);
            using (FileStream stream = new FileStream("clients.xml", FileMode.OpenOrCreate))
            {
                List<Client> clients = (List<Client>)serializer.Deserialize(stream);
                return clients;
            }
        }

    }
}