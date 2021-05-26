﻿using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Admin: Person
    {
        //Класс админ, содержащий информацию о админе
        public int IdEmpl { get; set; }
        public ServicDB servicDB;

        public Admin(string name, string surname, int age, string phoneNumber, int idEmpl /* ServicDb*/)
           : base(name, surname, age, phoneNumber)
        {
            IdEmpl = idEmpl;
            Role = StatusRole.Admin;
            // ServicDb
         }


        public override void UserInfo()
        {
            Console.WriteLine($"Name: { Name} \tSurname: { Surname} \tAge: { Age} " +
                $"\tPhone: { PhoneNumber} \tRole:{ Role} \tNumber Empl: {IdEmpl}");
        }

        public void ViewOrders()
        {

            foreach(var obj in servicDB.buy)
            {
                Console.WriteLine($"Client: {obj.client.Name} \tAdmin: {obj.admin.Name} \tCar: {obj.car.Brand} {obj.car.Model} \tDate: {obj.dateTime}"  );
            }
        }

        public void ViewOrder(int id)
        {

        }

    }
}
