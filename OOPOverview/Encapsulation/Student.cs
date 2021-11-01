using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Encapsulation
{
   public class Student
    {
        private int age;
        public Student()
        {

            this.CreatedDate = DateTime.Now;
        }

        public void SetAge(int age)
        {
            if (age < 16)
            {
                throw new ArgumentException("Yaş değeri eksi olamaz");
            }
            this.age = age;
        }

        public int GetAge()
        {
            return this.age;
        }


        private string name;
        public string Name
        {
            get { return name; }
            set { name = value; }
        }

        public string LastName { get; set; }

        public DateTime CreatedDate { get; private set; }








    }
}
