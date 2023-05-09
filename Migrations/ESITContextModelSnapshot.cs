﻿// <auto-generated />
using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using Projekt_PIV_BazaDanych_ESIT.Models;

#nullable disable

namespace Projekt_PIV_BazaDanych_ESIT.Migrations
{
    [DbContext(typeof(ESITContext))]
    partial class ESITContextModelSnapshot : ModelSnapshot
    {
        protected override void BuildModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .HasAnnotation("ProductVersion", "7.0.5")
                .HasAnnotation("Relational:MaxIdentifierLength", 128);

            SqlServerModelBuilderExtensions.UseIdentityColumns(modelBuilder);

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.OfertaTurystyczna", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Oferty_Turystycznej");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DataPrzyjazdu")
                        .HasColumnType("datetime2");

                    b.Property<DateTime>("DataWyjazdu")
                        .HasColumnType("datetime2");

                    b.Property<string>("Kategoria")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("Koszt")
                        .HasColumnType("int");

                    b.Property<string>("MiejsceDocelowe")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("MiejsceWyjazdu")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("OfertyTurystyczne");
                });

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.Opinie", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Opini");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DataWystawienia")
                        .HasColumnType("datetime2");

                    b.Property<int>("Ocena")
                        .HasColumnType("int");

                    b.Property<int>("OfertaTurystycznaID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OfertaTurystycznaID");

                    b.ToTable("Opinie");
                });

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.Rezerwacja", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Rezerwacji");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DataRezerwacji")
                        .HasColumnType("datetime2");

                    b.Property<int>("Koszt")
                        .HasColumnType("int");

                    b.Property<int>("LiczbaOsób")
                        .HasColumnType("int");

                    b.Property<int>("OfertaTurystycznaID")
                        .HasColumnType("int");

                    b.Property<int>("UżytkownicyID")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("OfertaTurystycznaID");

                    b.HasIndex("UżytkownicyID");

                    b.ToTable("Rezerwacje");
                });

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.Użytkownicy", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Użytkownika");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<DateTime>("DataUrodzenia")
                        .HasColumnType("datetime2");

                    b.Property<string>("Email")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Haslo")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Imie")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Nazwisko")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ID");

                    b.ToTable("Użytkownicy");
                });

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.Wiadomości", b =>
                {
                    b.Property<int>("ID")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .HasColumnName("ID_Wiadomości");

                    SqlServerPropertyBuilderExtensions.UseIdentityColumn(b.Property<int>("ID"));

                    b.Property<int>("RezerwacjaID")
                        .HasColumnType("int");

                    b.Property<string>("Tekst")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Temat")
                        .IsRequired()
                        .HasColumnType("nvarchar(max)");

                    b.Property<int>("UżytkownicyID")
                        .HasColumnType("int");

                    b.Property<int?>("UżytkownicyID1")
                        .HasColumnType("int");

                    b.HasKey("ID");

                    b.HasIndex("RezerwacjaID");

                    b.HasIndex("UżytkownicyID");

                    b.HasIndex("UżytkownicyID1");

                    b.ToTable("Wiadomości");
                });

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.Opinie", b =>
                {
                    b.HasOne("Projekt_PIV_BazaDanych_ESIT.Models.OfertaTurystyczna", "OfertaTurystyczna")
                        .WithMany("Opinie")
                        .HasForeignKey("OfertaTurystycznaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OfertaTurystyczna");
                });

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.Rezerwacja", b =>
                {
                    b.HasOne("Projekt_PIV_BazaDanych_ESIT.Models.OfertaTurystyczna", "OfertaTurystyczna")
                        .WithMany("Rezerwacja")
                        .HasForeignKey("OfertaTurystycznaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekt_PIV_BazaDanych_ESIT.Models.Użytkownicy", "Użytkownicy")
                        .WithMany("Rezerwacja")
                        .HasForeignKey("UżytkownicyID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.Navigation("OfertaTurystyczna");

                    b.Navigation("Użytkownicy");
                });

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.Wiadomości", b =>
                {
                    b.HasOne("Projekt_PIV_BazaDanych_ESIT.Models.Rezerwacja", "Rezerwacja")
                        .WithMany("wiadomościs")
                        .HasForeignKey("RezerwacjaID")
                        .OnDelete(DeleteBehavior.Cascade)
                        .IsRequired();

                    b.HasOne("Projekt_PIV_BazaDanych_ESIT.Models.Użytkownicy", "Użytkownicy")
                        .WithMany()
                        .HasForeignKey("UżytkownicyID")
                        .OnDelete(DeleteBehavior.Restrict)
                        .IsRequired();

                    b.HasOne("Projekt_PIV_BazaDanych_ESIT.Models.Użytkownicy", null)
                        .WithMany("Wiadomości")
                        .HasForeignKey("UżytkownicyID1");

                    b.Navigation("Rezerwacja");

                    b.Navigation("Użytkownicy");
                });

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.OfertaTurystyczna", b =>
                {
                    b.Navigation("Opinie");

                    b.Navigation("Rezerwacja");
                });

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.Rezerwacja", b =>
                {
                    b.Navigation("wiadomościs");
                });

            modelBuilder.Entity("Projekt_PIV_BazaDanych_ESIT.Models.Użytkownicy", b =>
                {
                    b.Navigation("Rezerwacja");

                    b.Navigation("Wiadomości");
                });
#pragma warning restore 612, 618
        }
    }
}
