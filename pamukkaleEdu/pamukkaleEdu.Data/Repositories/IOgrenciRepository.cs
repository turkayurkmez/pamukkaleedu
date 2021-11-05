using pamukkaleEdu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Data.Repositories
{
   public interface IOgrenciRepository : IRepository<Ogrenci>
    {
        Task<Ogrenci> GetStudentByStudentNo(string ogrenciNo);
        Task<bool> IsExists(int id);

        Task<bool> AddStudentAndCourse(Ogrenci ogrenci, Ders ders);
    }
}
