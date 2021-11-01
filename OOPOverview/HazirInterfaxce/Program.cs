using System;

namespace HazirInterfaxce
{
    class Program
    {
        static void Main(string[] args)
        {
            ClassRoom classRoom = new ClassRoom();
            classRoom.Add(new Student { Id = 1, Age = 41, LastName = "Ürkmez", Name = "Türkay" });
            classRoom.Add(new Student { Id = 1, Age = 41, LastName = "Osmanoğlu", Name = "Sinan" });
            classRoom.Add(new Student { Id = 2, Age = 37, LastName = "Korkmaz", Name = "Tarık" });
            classRoom.Add(new Student { Id = 3, Age = 25, LastName = "Galip", Name = "Hikmet" });
            classRoom.Add(new Student { Id = 4, Age = 23, LastName = "Eski", Name = "Cansu" });

            classRoom.GetStudents();

            foreach (var item in classRoom)
            {
                Console.WriteLine($"{item.Id} {item.Name} {item.Age}");
            }

        }
    }
}
