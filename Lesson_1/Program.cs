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

            foreach (Type t in types)
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


        }
    }

}
