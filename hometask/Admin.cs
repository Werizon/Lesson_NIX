using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Admin: Person
    {
        //Класс админ, содержащий информацию о админе
        public int IdEmpl { get; set; }

        public Admin(string name, string surname, int age, string phoneNumber, int idEmpl)
           : base(name, surname, age, phoneNumber)
        {
            IdEmpl = idEmpl;
            Role = StatusRole.Admin;
        }


        public override void UserInfo()
        {
            Console.WriteLine($"Name: { Name} \tSurname: { Surname} \tAge: { Age} " +
                $"\tPhone: { PhoneNumber} \tRole:{ Role} \tNumber Empl: {IdEmpl}");
        }



    }
}
