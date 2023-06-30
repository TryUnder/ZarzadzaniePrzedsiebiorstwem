﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    [DbContext(typeof(MyDbContext))]
    partial class MyDbContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "6.0.16")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder, 1L, 1);

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.Authentication.User", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Pracownik", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<DateTime>("DataUrodzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("ImieNazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiejsceUrodzenia")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Pesel")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrzadSkarbowyId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("UrzadSkarbowyId");

                    b.ToTable("Pracownik");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Przedsiebiorstwo", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<int>("FormaPrawna")
                        .HasColumnType("int");

                    b.Property<string>("NIP")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazwaPelna")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("NazwaSkrocona")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("PowiatGmina")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("REGON")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RachunekBankowy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UrzadSkarbowyId")
                        .HasColumnType("int");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Wojewodztwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("daneAdresowe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UrzadSkarbowyId");

                    b.HasIndex("UserId");

                    b.ToTable("Przedsiebiorstwo");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.UrzadSkarbowy", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Adres")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("KodUs")
                        .HasColumnType("int");

                    b.Property<string>("Nazwa")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("RachunekBankowy")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("UrzadSkarbowy");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Pracownik", b =>
                {
                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.UrzadSkarbowy", "UrzadSkarbowy")
                        .WithMany()
                        .HasForeignKey("UrzadSkarbowyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UrzadSkarbowy");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Przedsiebiorstwo", b =>
                {
                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.UrzadSkarbowy", "UrzadSkarbowy")
                        .WithMany()
                        .HasForeignKey("UrzadSkarbowyId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.Authentication.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("UrzadSkarbowy");

                    b.Navigation("User");
                });
#pragma warning restore 612, 618
        }
    }
}
