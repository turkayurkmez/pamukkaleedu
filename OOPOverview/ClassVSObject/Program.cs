using System;

namespace ClassVSObject
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student1 = new Student();
            student1.Name = "Türkay";

            Student student2 = student1;

            student2.Name = "Kadir";

            Console.WriteLine(student1.Name);



        }
    }
}
