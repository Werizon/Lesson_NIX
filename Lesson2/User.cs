using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.Lesson2
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Surname { get; set; }
        public int PhoneNumber { get; set; }
        public string Email { get; set; }
        public string Role { get; set; }
        public ICollection<Order> Orders { get; set; }
        public ICollection<Cart> Carts { get; set; }

        public User(string name, string surname, int phoneNumber, string email, string role)
        {
            Name = name;
            Surname = surname;
            PhoneNumber = phoneNumber;
            Email = email;
            Role = role;
        }

    }
}
