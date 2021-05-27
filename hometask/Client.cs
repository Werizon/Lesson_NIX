using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    class Client : Person
    {
        //Класс клиент, содержащий информацию о клиенте
        public int discount { get; set; }
        

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
    }


}
