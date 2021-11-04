using Microsoft.EntityFrameworkCore;
using pamukkaleEdu.Data.Context;
using pamukkaleEdu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Data.Repositories
{
    public class EFOgrenciRepository : IOgrenciRepository
    {

        private PauDbContext dbContext;
        public EFOgrenciRepository(PauDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
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
            throw new NotImplementedException();
        }

        public async Task<IEnumerable<Ogrenci>> GetAllEntitiesAync()
        {
            var ogrenciler = await dbContext.Ogrenciler.ToListAsync();
            return ogrenciler;
        }

        public IEnumerable<Ogrenci> GetEntitiesWithCredential(Expression<Func<Ogrenci, bool>> predicate)
        {
            throw new NotImplementedException();
        }

        public Task<Ogrenci> GetEntityById(int id)
        {
            throw new NotImplementedException();
        }

        public async Task<Ogrenci> GetStudentByStudentNo(string ogrenciNo)
        {
            var ogrenci = await dbContext.Ogrenciler.Include(ogr => ogr.DersDetaylari)
                                              .ThenInclude(detay => detay.Ders)
                                              .FirstOrDefaultAsync(ogr => ogr.OgrenciNo == ogrenciNo);

            return ogrenci;

        }

        public Task<Ogrenci> UpdateEntity(Ogrenci newEntity)
        {
            throw new NotImplementedException();
        }
    }
}
