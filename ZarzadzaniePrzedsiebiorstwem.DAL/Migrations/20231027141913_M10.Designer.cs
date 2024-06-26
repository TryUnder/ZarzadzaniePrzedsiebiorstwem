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
    [Migration("20231027141913_M10")]
    partial class M10
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

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe.Bilans", b =>
                {
                    b.Property<int>("BilansId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("BilansId"), 1L, 1);

                    b.Property<decimal>("AktywaObrotowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("AktywaTrwale")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InneInwestycjeKrotkoterminowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InwestycjeDlugoterminowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("InwestycjeKrotkoterminowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KapitalFunduszPodstawowy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KapitalFunduszWlasny")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KredytyIPozyczki")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KredytyIPozyczkiKrotkoterminowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KrotkoterminoweAktywaFinansowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("KrotkoterminoweRozliczeniaMiedzyokresowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Materialy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NalezneWplatyNaKapitalPodstawowy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NaleznosciDlugoterminowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NaleznosciDochodzoneNaDrodzeSadowej")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NaleznosciKrotkoterminowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NaleznosciZTytuluDostawIUslug")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("NaleznosciZTytuluPodatkow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("OdpisyZZyskuNettoWCiaguRokuObrotowego")
                        .HasColumnType("decimal(18,2)");

                    b.Property<DateTime>("OkresRozliczeniowy")
                        .HasColumnType("datetime2");

                    b.Property<decimal>("PolproduktyIProduktyWToku")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PozostaleKapitaly")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PozostaleNaleznosci")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("PozostaleZobowiazania")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ProduktyGotowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RezerwyNaZobowiazania")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RozliczeniaDlugoterminowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RozliczeniaMiedzyokresowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("RzeczoweAktywaTrwale")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SrodkiTrwale")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SrodkiTrwaleWBudowie")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SumaBilansowaAktywow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("SumaBilansowaPasywow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Towary")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("UdzialyWlasne")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
                        .HasColumnType("int");

                    b.Property<decimal>("WartosciNiematerialneIPrawne")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZaliczkaNaSrodkiTrwaleWBudowie")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZaliczkiNaDostawy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZaliczkiOtrzymaneNaDostawy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("Zapasy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZobowiazaniaDlugoterminowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZobowiazaniaIRezerwyNaZobowiazania")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZobowiazaniaKrotkoterminowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZobowiazaniaWekslowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZobowiazaniaZTytuluWynagrodzen")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZobowiazaniaZTytyuluDostawIUslug")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZobowiazaniaZTytyuluPodatkow")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZyskStrataNetto")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal>("ZyskStrataZLatUbieglych")
                        .HasColumnType("decimal(18,2)");

                    b.HasKey("BilansId");

                    b.HasIndex("UserId");

                    b.ToTable("Bilans");
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

                    b.Property<decimal?>("Dotacje")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("Dywidendy")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("InneKosztyFinansowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("InneKosztyOperacyjne")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("InnePrzychodyFinansowe")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("InnePrzychodyOperacyjne")
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

                    b.Property<decimal?>("PozostaleObowiazkoweZmniejszeniaZysku")
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

                    b.Property<decimal?>("StrataZTytuluRozchoduAktywowFinansowych")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("StrataZTytuluRozchoduNiefinansowychAktywowTrwalych")
                        .HasColumnType("decimal(18,2)");

                    b.Property<decimal?>("UbezpieczeniaSpoleczneIInneSwiadczenia")
                        .HasColumnType("decimal(18,2)");

                    b.Property<int>("UserId")
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

                    b.Property<decimal?>("ZuzycieMaterialowIEnergii")
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

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe.Bilans", b =>
                {
                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.Authentication.User", "User")
                        .WithMany("Bilans")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.DataModels.SprawozdaniaFinansowe.RachunekZyskowIStrat", b =>
                {
                    b.HasOne("ZarzadzaniePrzedsiebiorstwem.Model.Authentication.User", "User")
                        .WithMany("RachunkiZyskowIStrat")
                        .HasForeignKey("UserId")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("User");
                });

            modelBuilder.Entity("ZarzadzaniePrzedsiebiorstwem.Model.Authentication.User", b =>
                {
                    b.Navigation("Bilans");

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
