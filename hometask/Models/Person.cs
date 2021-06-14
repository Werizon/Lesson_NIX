using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    enum StatusRole
    {
        Client,
        Admin
    }
    [Serializable]
    abstract class Person
    {

        //Абстрактный класс, являющийся базовым для классов Admin и Client.
        private static int Id { get; set; }
        public int PasportId { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public string PhoneNumber { get; set; }

        public StatusRole Role { get; set; }

        public Person() { }

        public Person(string name, string surname, int age, string phoneNumber)
        {
            Id++;
            Name = name;
            Surname = surname;
            Age = age;
            PhoneNumber = phoneNumber;
            PasportId = Id;
        }

        public abstract void UserInfo();

        public void ChangePassword() { }

    }
}
