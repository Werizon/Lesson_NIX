using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    [Serializable]
    class Client : Person
    {
        //Класс клиент, содержащий информацию о клиенте
        public int discount { get; set; }

        public Client() { }
        public Client(string name, string surname, int age, string phoneNumber, int disc)
            : base(name, surname, age, phoneNumber)
        {
            discount = disc;
            Role = StatusRole.Client;
        }
 
        public void DiscountInfo()
        {
            Console.WriteLine($"Песональная скидка: {discount}%");
        }

        public override void UserInfo()
        {
            Console.WriteLine("Информация про пользователя");
            Console.WriteLine($"Name: { Name} \tSurname: { Surname} \tAge: { Age} " +
                $"\tPhone: { PhoneNumber} \tRole:{ Role} \t { discount}");
        }

    }
}
