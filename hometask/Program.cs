﻿using Lesson_NIX_2.hometask.Models;
using Newtonsoft.Json;
using System;
using System.Collections.Generic;
using System.IO;
using System.Text.Json.Serialization;
using System.Xml.Serialization;

namespace Lesson_NIX_2.hometask
{
    class Program
    {
        public static void SaveUserInfo(List<Client> clients)
        {
            string json = JsonConvert.SerializeObject(clients);
            using (FileStream fs = new FileStream("clients.json", FileMode.OpenOrCreate))
            using (StreamWriter writer = new StreamWriter("clients.json"))
            {
                writer.WriteLine(json);
            }
        }

        public static List<Client> LoadClientsInfo()
        {
            string json;
            using (StreamReader reader = new StreamReader("clients.json"))
            {
                json = reader.ReadToEnd();
                var clients = JsonConvert.DeserializeObject<List<Client>>(json);
                Console.WriteLine("Json File");
                foreach (Client client in clients)
                {
                    Console.WriteLine($"Name: {client.Name} \t Surname: {client.Surname} \tDiscount: {client.discount}");
                }
                return clients;
            }

        }

        static void Main(string[] args)
        {
            
            Services services = new Services();

            PassagerCar nissanNX3 = new PassagerCar("Nissan", "NX-3", "Sedan", "Grey", 2020, 7000, 160, "Только из салона", 8, "Turbo 1.3", "Disel");
            PassagerCar opel = new PassagerCar("Opel", "Turbo", "Universal", "Black", 2000, 5000, 150, "Только из салона", 7, "Class 3", "Benz");
            JeepCar jeep = new JeepCar("Jeep", "Kundro", "Pikap", "Dark Green", 2015, 6500, 140, "4WD", "Описание джипа", 10.5, "Nadd 730", "Benzin", "Комфорт");

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


            List<Client> clients = new List<Client>();
            clients.Add(client1);
            clients.Add(client2);

            SaveUserInfo(clients);
            LoadClientsInfo();


        }


    }
}