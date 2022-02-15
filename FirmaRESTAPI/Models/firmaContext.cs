using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirmaRESTAPI.Models
{
    public partial class firmaContext : DbContext
    {
        public firmaContext()
        {
        }

        public firmaContext(DbContextOptions<firmaContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Divizie> Divizies { get; set; } = null!;
        public virtual DbSet<Firma> Firmas { get; set; } = null!;
        public virtual DbSet<Oddelenium> Oddelenia { get; set; } = null!;
        public virtual DbSet<Projekty> Projekties { get; set; } = null!;
        public virtual DbSet<Zamestnanci> Zamestnancis { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLEXPRESS01;Database=firma;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Divizie>(entity =>
            {
                entity.ToTable("Divizie");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdVeduciDiv).HasColumnName("ID_veduci_div");

                entity.Property(e => e.Nazov).HasMaxLength(50);

                entity.HasOne(d => d.IdVeduciDivNavigation)
                    .WithMany(p => p.Divizies)
                    .HasForeignKey(d => d.IdVeduciDiv)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Divizie_Zamestnanci");
            });

            modelBuilder.Entity<Firma>(entity =>
            {
                entity.ToTable("Firma");

                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdRiaditel).HasColumnName("ID_riaditel");

                entity.Property(e => e.Nazov).HasMaxLength(50);

                entity.HasOne(d => d.IdRiaditelNavigation)
                    .WithMany(p => p.Firmas)
                    .HasForeignKey(d => d.IdRiaditel)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Firma_Zamestnanci");
            });

            modelBuilder.Entity<Oddelenium>(entity =>
            {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdVeduciOdd).HasColumnName("ID_veduci_odd");

                entity.Property(e => e.Nazov).HasMaxLength(50);

                entity.HasOne(d => d.IdVeduciOddNavigation)
                    .WithMany(p => p.Oddelenia)
                    .HasForeignKey(d => d.IdVeduciOdd)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Oddelenia_Zamestnanci");
            });

            modelBuilder.Entity<Projekty>(entity =>
            {
                entity.ToTable("Projekty");

                entity.Property(e => e.Id)
                    .ValueGeneratedNever()
                    .HasColumnName("ID");

                entity.Property(e => e.IdVeduciProj).HasColumnName("ID_veduci_proj");

                entity.Property(e => e.Nazov).HasMaxLength(50);

                entity.HasOne(d => d.IdVeduciProjNavigation)
                    .WithMany(p => p.Projekties)
                    .HasForeignKey(d => d.IdVeduciProj)
                    .OnDelete(DeleteBehavior.ClientSetNull)
                    .HasConstraintName("FK_Projekty_Zamestnanci");
            });

            modelBuilder.Entity<Zamestnanci>(entity =>
            {
                entity.ToTable("Zamestnanci");

                entity.Property(e => e.Email).HasMaxLength(50);

                entity.Property(e => e.Meno).HasMaxLength(50);

                entity.Property(e => e.Priezvisko).HasMaxLength(50);

                entity.Property(e => e.Telefon).HasMaxLength(50);

                entity.Property(e => e.Titul).HasMaxLength(50);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
