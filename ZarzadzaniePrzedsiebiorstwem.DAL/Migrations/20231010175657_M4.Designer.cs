﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ZarzadzaniePrzedsiebiorstwem.DAL.EF;

#nullable disable

namespace ZarzadzaniePrzedsiebiorstwem.DAL.Migrations
{
    [DbContext(typeof(MyDbContext))]
    [Migration("20231010175657_M4")]
    partial class M4
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
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

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Login")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.ToTable("User");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Planner", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Description")
                        .HasColumnType("nvarchar(max)");

                    b.Property<DateTime?>("DueDate")
                        .HasColumnType("datetime2");

                    b.Property<int?>("TagId")
                        .HasColumnType("int");

                    b.Property<string>("TaskList")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("TaskName")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("TagId");

                    b.HasIndex("UserId");

                    b.ToTable("Planner");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Subtask", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlannerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlannerId");

                    b.ToTable("SubTask");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Tag", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<string>("Name")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("PlannerId")
                        .HasColumnType("int");

                    b.HasKey("Id");

                    b.HasIndex("PlannerId");

                    b.ToTable("Tag");
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

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<string>("Wojewodztwo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("daneAdresowe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("Przedsiebiorstwo");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe.RachunekZyskowIStrat", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("Id"), 1L, 1);

                    b.Property<decimal?>("AktualizacjaWartosciAktywowFinansowych")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("AktualizacjaWartosciAktywowFinansowychStrata")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Amortyzacja")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("DataKoncowa")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataPoczatkowa")
                        .HasColumnType("datetime2");

                    b.Property<decimal?>("Dywidendy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Inne")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("InneKosztyFinansowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("InneKosztyOperacyjne")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("InnePrzychodyOperacyjne")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Inwestycje")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("KosztWytworzeniaProduktowNaWlasnePotrzebyJednostki")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KosztyDzialalnosciOperacyjnej")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KosztyFinansowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("OdsetkiDlaFirmy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("OdsetkiNaRzeczInnych")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PodatekDochodowy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PodatkiIOplaty")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PozostaleKosztyOperacyjne")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PozostaleKosztyRodzajowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PozostaleObowiazkoweZmniejszeniaZysku")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PozostalePrzychodyOperacyjne")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrzychodyFinansowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PrzychodyNettoZeSprzedazy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PrzychodyNettoZeSprzedazyProduktow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("PrzychodyNettoZeSprzedazyTowarowIMaterialow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("SkladkiNaZus")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("StrataZTytuluRozchoduAktywowFinansowych")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("StrataZTytuluRozchoduNiefinansowychAktywow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int?>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal?>("UslugiObce")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("WartoscSprzedanychTowarowIMaterialow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Wynagrodzenia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ZmianaStanuProduktow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ZmniejszenieWartosciAktywowNiefinansowych")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ZuzycieMaterialowIProduktow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ZwiekszenieWartosciAktywowNiefinansowych")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZyskStrataBrutto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZyskStrataNetto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZyskStrataZDzialalnosciOperacyjnej")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZyskStrataZeSprzedazy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ZyskZTytuluRozchoduAktywowFinansowych")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("ZyskZTytuluRozchoduNiefinansowychAktywowTrwalych")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("Id");

                    b.HasIndex("UserId");

                    b.ToTable("RachunekZyskowIStrat");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Planner", b =>
                {
                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Tag", null)
                        .WithMany("Tasks")
                        .HasForeignKey("TagId");

                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.Authentication.User", "User")
                        .WithMany("Planners")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Subtask", b =>
                {
                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Planner", "Planner")
                        .WithMany("Subtask")
                        .HasForeignKey("PlannerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planner");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Tag", b =>
                {
                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Planner", "Planner")
                        .WithMany("Tags")
                        .HasForeignKey("PlannerId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("Planner");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Przedsiebiorstwo", b =>
                {
                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.Authentication.User", "User")
                        .WithMany()
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe.RachunekZyskowIStrat", b =>
                {
                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.Authentication.User", null)
                        .WithMany("RachunkiZyskowIStrat")
                        .HasForeignKey("UserId");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.Authentication.User", b =>
                {
                    b.Navigation("Planners");

                    b.Navigation("RachunkiZyskowIStrat");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Planner", b =>
                {
                    b.Navigation("Subtask");

                    b.Navigation("Tags");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.Planner.Tag", b =>
                {
                    b.Navigation("Tasks");
                });
#pragma warning restore 612, 618
        }
    }
}
