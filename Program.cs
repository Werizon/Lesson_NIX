using System;
using System.Reflection;


namespace LNix1
{
    class Program
    {
        static void Main(string[] args)
        {

            Assembly asm_user = Assembly.LoadFrom(@"C:\Users\Badyan\source\repos\LNix1\ClassLibraryLNix_1.dll");
            Console.WriteLine(asm_user.FullName);
            Type[] types = asm_user.GetTypes();

            foreach(Type t in types)
            {
                Console.WriteLine("Type: {0}", t.Name);
            }
            Console.WriteLine("---------");



            Assembly asm_lesson = Assembly.LoadFrom("ClassLibrary2LNix1");
            string FullName = asm_lesson.FullName;
            Console.WriteLine(FullName);

            Type[] typess = asm_lesson.GetTypes();

            foreach (Type t in typess)
            {
                Console.WriteLine("Namespace: {0},\tIs Array?: {1},\tIs Class?: {2}, \tName: {3}", t.Namespace, t.IsArray, t.IsClass, t.Name);
            }
            Console.WriteLine("---------");

            


            //Type ttype = Type.GetType("LNix1.User", false, true);
            //foreach (MemberInfo memberInfo in ttype.GetMembers())
            //{
            //    Console.WriteLine($"{ memberInfo.DeclaringType} \t{memberInfo.MemberType} \t{memberInfo.Name} ");
            //}
            //Console.WriteLine("");


            //Type type = typeof(User);
            //Console.WriteLine(type.ToString());

            //User user = new User("Test", 20);
            //Console.WriteLine(user);

        }
    }

    //public class User
    //{
    //    public string Name { get; set; }
    //    public int Age { get; set; }
    //    public User(string name, int age)
    //    {
    //        Name = name;
    //        Age = age;
    //    }

    //    public override string ToString()
    //    {
    //        return ($"Name: { Name} \tAge: { Age}");
    //    }
    //}

}
