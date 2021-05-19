using System;

namespace Lesson_NIX_2
{

    struct User
    {

        public string Name;
        public int Age;

        public User(string Name, int Age)
        {
            this.Name = Name;
            this.Age = Age;
        }
        public void DisplayInfo()
        {
            Console.WriteLine(Name + " " + Age.ToString());
        }
    }

    class Person
    {
        public string name;
        public int age = 18;

        // first constructor
        public Person() : this("NoName")
        {
        }

        public Person(string name) : this(name, 18)
        {
        }

        public Person(string name, int age)
        {
            this.name = name;
            this.age = age;
        }

        public void GetInfo()
        {
            Console.WriteLine(name + age.ToString());
        }


    }


    class Program
    {
        static void Main(string[] args)
        {

            Person bob = new Person("Bob");
            Person nick = new Person("Nick", 20);

            bob.GetInfo();
            nick.GetInfo();

            ///answer?
            Person tom = new Person("Tom", 34) { name = "Bob", age = 29 };
            tom.GetInfo();

            ///struct
            Console.WriteLine("\nSTRUCT");
            User tim;
            tim.Name = "Tim";
            tim.Age = 21;
            tim.DisplayInfo();

            Console.WriteLine("");
            User tim2 = new User("Tim2", 30);
            tim2.DisplayInfo();

            User tolya = new User() { Name = "Tim3", Age = 33 };
            tolya.DisplayInfo();


        }
    }
}


