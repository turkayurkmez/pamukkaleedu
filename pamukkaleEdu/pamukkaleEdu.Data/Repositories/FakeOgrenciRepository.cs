using pamukkaleEdu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Data.Repositories
{
    public class FakeOgrenciRepository : IOgrenciRepository
    {
        private List<Ogrenci> ogrenciler = new List<Ogrenci>
        {
            new Ogrenci{ Id=1, Ad="Çağrı", OgrenciNo="20171001", Program="Bilgisayar Müh.", Durum="Mezun"},
            new Ogrenci{ Id=2, Ad="Türkay", OgrenciNo="20210001", Program="Bilgisayar Müh.", Durum="Öğrenci"},
            new Ogrenci{ Id=3, Ad="Cüneyt", OgrenciNo="20141002", Program="Gıda Müh.", Durum="Öğrenci"},


        };
        public Task<Ogrenci> AddEntity(Ogrenci newEntity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(Ogrenci entity)
        {
            throw new NotImplementedException();
        }

        public Task<int> Delete(int id)
        {
            throw new NotImplementedException();
        }

        public IEnumerable<Ogrenci> GetAllEntities()
        {
            return ogrenciler;

        }

        public async Task<IEnumerable<Ogrenci>> GetAllEntitiesAync()
        {
            return await Task.FromResult(ogrenciler);
        }

        public IEnumerable<Ogrenci> GetEntitiesWithCredential(Expression<Func<Ogrenci, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Ogrenci> GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ogrenci> GetStudentByStudentNo(string ogrenciNo)
        {
            throw new NotImplementedException();
        }

        public Task<bool> IsExists(int id)
        {
            throw new NotImplementedException();
        }

        public Task<Ogrenci> UpdateEntity(Ogrenci newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
