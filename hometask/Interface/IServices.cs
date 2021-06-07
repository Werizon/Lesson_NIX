using System;
using System.Collections.Generic;
using System.Text;

namespace Lesson_NIX_2.hometask
{
    interface IServices
    {
        void TestDrive(Auto car, Client client, DateTime dateTim);
        void PreOrder(Auto car, Client client, DateTime dateTim);
        void Buy(Client client, Auto car, Admin admin);
        void AddUserToList(Person user);
        void AddAutoToList(Auto car);
        void ViewUsers();
        void ViewAvtos();

    }
}
