using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Storage;
using pamukkaleEdu.Data.Context;
using pamukkaleEdu.Entities;
using System;
using System.Collections.Generic;
using System.Data.Entity;
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
        public async Task<Ogrenci> AddEntity(Ogrenci newEntity)
        {
            newEntity.OlusturulmaTarihi = DateTime.Now;
            dbContext.Ogrenciler.Add(newEntity);
            int result = await dbContext.SaveChangesAsync();
            return result > 0 ? newEntity : null;
        }

        public async Task<bool> AddStudentAndCourse(Ogrenci ogrenci, Ders ders)
        {
            //Eğer ders EKLENEMEZ ise Öğrenci'yi geri alacaksın!!!!!!
            using (dbContext)
            {
                using (IDbContextTransaction transaction = dbContext.Database.BeginTransaction())
                {
                    try
                    {
                        dbContext.Ogrenciler.Add(ogrenci);
                        await dbContext.SaveChangesAsync();

                        dbContext.Dersler.Add(ders);
                        await dbContext.SaveChangesAsync();

                        transaction.Commit();
                        return true;
                    }
                    catch (Exception)
                    {

                        transaction.Rollback();
                        return false;
                    }
                }


            }
        }

        public async Task<int> Delete(Ogrenci entity)
        {
            dbContext.Ogrenciler.Remove(entity);
            var result = await dbContext.SaveChangesAsync();
            return result;

        }

        public Task<int> Delete(int id)
        {
            var entity = dbContext.Ogrenciler.FirstOrDefault(x => x.Id == id);
            return Delete(entity);
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

        public async Task<bool> IsExists(int id)
        {
            return await dbContext.Ogrenciler.AnyAsync(ogr => ogr.Id == id);


        }

        public async Task<Ogrenci> UpdateEntity(Ogrenci newEntity)
        {
            var result = dbContext.Ogrenciler.Update(newEntity);

            await dbContext.SaveChangesAsync();
            return result.Entity;

        }
    }
}
