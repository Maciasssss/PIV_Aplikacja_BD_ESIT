using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Projekt_PIV_BazaDanych_ESIT.Models
{
    public class ESITContext : DbContext
    {
        public ESITContext()
        {
        }
        public ESITContext(DbContextOptions<ESITContext> options) : base(options)
        {
        }

        public virtual DbSet<Rezerwacja> Rezerwacje { get; set; }
        public virtual DbSet<Użytkownicy> Użytkownicy { get; set; }
        public virtual DbSet<OfertaTurystyczna> OfertyTurystyczne { get; set; }
        public virtual DbSet<Opinie> Opinie { get; set; }
        public virtual DbSet<Opinie> Wiadomości { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlServer("Server=DESKTOP-1M6ATAN;Database=ESIT;Integrated Security=True;Connect Timeout=30;Encrypt=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False;TrustServerCertificate=True;");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            base.OnModelCreating(modelBuilder);

            // ustawienia dla klasy Rezerwacja
            modelBuilder.Entity<Rezerwacja>()
                .HasOne(r => r.OfertaTurystyczna)
                .WithMany(o => o.Rezerwacja);

            modelBuilder.Entity<Rezerwacja>()
                .HasOne(r => r.Użytkownicy)
                .WithMany(u => u.Rezerwacja);

            // ustawienia dla klasy Opinie
            modelBuilder.Entity<Opinie>()
                .HasOne(o => o.OfertaTurystyczna)
                .WithMany(ot => ot.Opinie);

            // ustawienia dla klasy Wiadomości
            modelBuilder.Entity<Wiadomości>()
               .HasOne(w => w.Użytkownicy)
               .WithMany()
               .OnDelete(DeleteBehavior.Restrict);
            base.OnModelCreating(modelBuilder);
        }
    }
}
