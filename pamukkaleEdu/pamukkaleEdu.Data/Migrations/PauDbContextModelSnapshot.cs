﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using pamukkaleEdu.Data.Context;

namespace pamukkaleEdu.Data.Migrations
{
    [DbContext(typeof(PauDbContext))]
    partial class PauDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.11")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("pamukkaleEdu.Entities.Ders", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasMaxLength(100)
                        .HasColumnType("nvarchar(100)");

                    b.Property<int?>("PratikSure")
                        .HasColumnType("int");

                    b.Property<int?>("TeorikSure")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.ToTable("Dersler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Epistemoloji"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Fizik"
                        },
                        new
                        {
                            Id = 3,
                            Ad = "Matematik"
                        });
                });

            modelBuilder.Entity("pamukkaleEdu.Entities.Ogrenci", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

                    b.Property<string>("Ad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DogumTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Durum")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("GuncellemeTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("OgrenciNo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("OlusturulmaTarihi")
                        .HasColumnType("datetime2");

                    b.Property<string>("Program")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Soyad")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("Ogrenciler");

                    b.HasData(
                        new
                        {
                            Id = 1,
                            Ad = "Türkay",
                            OgrenciNo = "202100001",
                            Soyad = "Ürkmez"
                        },
                        new
                        {
                            Id = 2,
                            Ad = "Ahmet",
                            OgrenciNo = "202100002",
                            Soyad = "Dayıoğlu"
                        });
                });

            modelBuilder.Entity("pamukkaleEdu.Entities.OgrenciDersDetay", b =>
                {
                    b.Property<int>("DersId")
                        .HasColumnType("int");

                    b.Property<int>("OgrenciId")
                        .HasColumnType("int");

                    b.Property<int?>("Notu")
                        .HasColumnType("int");

                    b.HasKey("DersId", "OgrenciId");

                    b.HasIndex("OgrenciId");

                    b.ToTable("OgrencilerDersler");

                    b.HasData(
                        new
                        {
                            DersId = 1,
                            OgrenciId = 1
                        },
                        new
                        {
                            DersId = 3,
                            OgrenciId = 1
                        },
                        new
                        {
                            DersId = 2,
                            OgrenciId = 2
                        },
                        new
                        {
                            DersId = 3,
                            OgrenciId = 2
                        });
                });

            modelBuilder.Entity("pamukkaleEdu.Entities.OgrenciDersDetay", b =>
                {
                    b.HasOne("pamukkaleEdu.Entities.Ders", "Ders")
                        .WithMany("OgrenciDetaylari")
                        .HasForeignKey("DersId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("pamukkaleEdu.Entities.Ogrenci", "Ogrenci")
                        .WithMany("DersDetaylari")
                        .HasForeignKey("OgrenciId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Ders");

                    b.Navigation("Ogrenci");
                });

            modelBuilder.Entity("pamukkaleEdu.Entities.Ders", b =>
                {
                    b.Navigation("OgrenciDetaylari");
                });

            modelBuilder.Entity("pamukkaleEdu.Entities.Ogrenci", b =>
                {
                    b.Navigation("DersDetaylari");
                });
#pragma warning restore 612, 618
        }
    }
}