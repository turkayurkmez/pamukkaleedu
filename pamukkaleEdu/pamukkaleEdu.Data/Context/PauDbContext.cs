using Microsoft.EntityFrameworkCore;
using pamukkaleEdu.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace pamukkaleEdu.Data.Context
{
   public class PauDbContext : DbContext
    {
        public DbSet<Ogrenci>  Ogrenciler { get; set; }
        public DbSet<Ders> Dersler { get; set; }
        public DbSet<OgrenciDersDetay> OgrenciDersDetay  { get; set; }

        public PauDbContext(DbContextOptions<PauDbContext> options):base(options)
        {

        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            //Burada connection string ve bağlantı bilgisini (provider) yazabilirdik. Ancak bu tarz kritik verilerin ortam (environment) datalarından gelmesi gerekir.
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {

            //Burada yazılanlar, bir alternatif. Toplu halde db kurallarını burada gözlemliyoruz:
            modelBuilder.Entity<Ders>().Property(d => d.Ad).IsRequired()
                                                           .HasMaxLength(100);


           
            modelBuilder.Entity<Ders>().ToTable("Dersler");
            modelBuilder.Entity<OgrenciDersDetay>().ToTable("OgrencilerDersler");

            modelBuilder.Entity<OgrenciDersDetay>().HasKey("DersId", "OgrenciId");

            modelBuilder.Entity<Ogrenci>().HasMany(ogr => ogr.DersDetaylari)
                                          .WithOne(odd => odd.Ogrenci)
                                          .HasForeignKey(ders => ders.OgrenciId);

            modelBuilder.Entity<Ders>().HasMany(ders => ders.OgrenciDetaylari)
                                       .WithOne(odd => odd.Ders)
                                       .HasForeignKey(odd => odd.DersId);


            modelBuilder.Entity<Ogrenci>().HasData(new Ogrenci[]
            {
                new Ogrenci{ Id=1, Ad ="Türkay", Soyad="Ürkmez", OgrenciNo="202100001" },
                new Ogrenci{ Id=2, Ad ="Ahmet", Soyad="Dayıoğlu", OgrenciNo="202100002" }


            });

            modelBuilder.Entity<Ders>().HasData(new Ders[]
            {
                new Ders { Id=1, Ad="Epistemoloji"},
                new Ders { Id=2, Ad="Fizik"},
                new Ders { Id=3, Ad="Matematik"}


            });

            modelBuilder.Entity<OgrenciDersDetay>().HasData(new OgrenciDersDetay[]
            {
                new OgrenciDersDetay{ OgrenciId=1, DersId=1},
                new OgrenciDersDetay{ OgrenciId=1, DersId=3},
                new OgrenciDersDetay{ OgrenciId=2, DersId=2},
                new OgrenciDersDetay{ OgrenciId=2, DersId=3}
            });

            //Migration: db'yi hızlı oluşturmak için bir alternatiftir. CANLIDA KULLANIRKEN DİKKATLİ OLUNMALI

        }
    }
}
