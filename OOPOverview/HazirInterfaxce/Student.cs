using System;
using System.Collections;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace HazirInterfaxce
{
    public class Student : IComparable<Student>
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string LastName { get; set; }
        public int Age { get; set; }

        public int CompareTo(Student other)
        {
            if (this.Age < other.Age)
            {
                return -1;

            }
            else if (this.Age > other.Age)
            {
                return 1;
            }
            else
            {
                return 0;
            }
        }
    }

    public class ClassRoom: IEnumerable<Student>
    {
        List<Student> students = new List<Student>();
        public void Add(Student student)
        {
            students.Add(student);

        }

        public IEnumerator<Student> GetEnumerator()
        {
            foreach (var item in students)
            {
               yield return  item;
            }
        }

        public List<Student> GetStudents()
        {
            students.Sort();
            return students;
        }

        IEnumerator IEnumerable.GetEnumerator()
        {
            throw new NotImplementedException();
        }
    }
}
