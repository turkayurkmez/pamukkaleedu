using System;

namespace Encapsulation
{
    class Program
    {
        static void Main(string[] args)
        {
            Student student = new Student();
            Console.WriteLine("Kaç yaşındasınız?");
            int age = int.Parse(Console.ReadLine());
            student.SetAge(age);

            Console.WriteLine(student.GetAge());

            student.LastName = "Ürkmez";
            
            var user = new { Name = "x", Age = 5 };
            Console.WriteLine(user.GetType().Name);  
           
        }
    }
}
