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
    abstract class Person
    {
        //Абстрактный класс, являющийся базовым для классов Sallerи Klient.
        public int Id;
        public string Name { get; set; }
        public string Surname { get; set; }
        public int Age { get; set; }
        public int PhoneNumber { get; set; }
        StatusRole Role;
    }
}
