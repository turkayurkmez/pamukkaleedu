using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;
using ReverseEngineering.Models;

#nullable disable

namespace ReverseEngineering.Data
{
    public partial class PauDbContext : DbContext
    {
        public PauDbContext()
        {
        }

        public PauDbContext(DbContextOptions<PauDbContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Dersler> Derslers { get; set; }
        public virtual DbSet<Ogrenciler> Ogrencilers { get; set; }
        public virtual DbSet<OgrencilerDersler> OgrencilerDerslers { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=PauDb");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.HasAnnotation("Relational:Collation", "SQL_Latin1_General_CP1_CI_AS");

            modelBuilder.Entity<Dersler>(entity =>
            {
                entity.ToTable("Dersler");

                entity.Property(e => e.Ad)
                    .IsRequired()
                    .HasMaxLength(100);
            });

            modelBuilder.Entity<Ogrenciler>(entity =>
            {
                entity.ToTable("Ogrenciler");

                entity.Property(e => e.Ad).IsRequired();

                entity.Property(e => e.OgrenciNo).IsRequired();

                entity.Property(e => e.Soyad).IsRequired();
            });

            modelBuilder.Entity<OgrencilerDersler>(entity =>
            {
                entity.HasKey(e => new { e.DersId, e.OgrenciId });

                entity.ToTable("OgrencilerDersler");

                entity.HasIndex(e => e.OgrenciId, "IX_OgrencilerDersler_OgrenciId");

                entity.HasOne(d => d.Ders)
                    .WithMany(p => p.OgrencilerDerslers)
                    .HasForeignKey(d => d.DersId);

                entity.HasOne(d => d.Ogrenci)
                    .WithMany(p => p.OgrencilerDerslers)
                    .HasForeignKey(d => d.OgrenciId);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
