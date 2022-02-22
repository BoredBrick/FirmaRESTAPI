using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace FirmaRESTAPI.Models {
    public partial class firmaContext : DbContext {
        public firmaContext() {
        }

        public firmaContext(DbContextOptions<firmaContext> options)
            : base(options) {
        }

        public virtual DbSet<Divizie> Divizie { get; set; } = null!;
        public virtual DbSet<Firma> Firma { get; set; } = null!;
        public virtual DbSet<Oddelenia> Oddelenia { get; set; } = null!;
        public virtual DbSet<Projekty> Projekty { get; set; } = null!;
        public virtual DbSet<Zamestnanci> Zamestnanci { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder) {
            if (!optionsBuilder.IsConfigured) {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Server=.\\SQLExpress01;Database=firma;Trusted_Connection=True;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder) {
            modelBuilder.Entity<Divizie>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdPatriPod).HasColumnName("ID_patri_pod");

                entity.Property(e => e.IdVeduci).HasColumnName("ID_veduci");

                entity.Property(e => e.Nazov).HasMaxLength(50);

                entity.HasOne(d => d.IdPatriPodNavigation)
                    .WithMany(p => p.Divizie)
                    .HasForeignKey(d => d.IdPatriPod)
                    .HasConstraintName("FK_Divizie_Firma");

                entity.HasOne(d => d.IdVeduciNavigation)
                    .WithMany(p => p.Divizie)
                    .HasForeignKey(d => d.IdVeduci)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Divizie_Zamestnanci");
            });

            modelBuilder.Entity<Firma>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdVeduci).HasColumnName("ID_veduci");

                entity.Property(e => e.Nazov).HasMaxLength(50);

                entity.HasOne(d => d.IdVeduciNavigation)
                    .WithMany(p => p.Firma)
                    .HasForeignKey(d => d.IdVeduci)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Firma_Zamestnanci");
            });

            modelBuilder.Entity<Oddelenia>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdPatriPod).HasColumnName("ID_patri_pod");

                entity.Property(e => e.IdVeduci).HasColumnName("ID_veduci");

                entity.Property(e => e.Nazov).HasMaxLength(50);

                entity.HasOne(d => d.IdPatriPodNavigation)
                    .WithMany(p => p.Oddelenia)
                    .HasForeignKey(d => d.IdPatriPod)
                    .HasConstraintName("FK_Oddelenia_Projekty");

                entity.HasOne(d => d.IdVeduciNavigation)
                    .WithMany(p => p.Oddelenia)
                    .HasForeignKey(d => d.IdVeduci)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Oddelenia_Zamestnanci");
            });

            modelBuilder.Entity<Projekty>(entity => {
                entity.Property(e => e.Id).HasColumnName("ID");

                entity.Property(e => e.IdPatriPod).HasColumnName("ID_patri_pod");

                entity.Property(e => e.IdVeduci).HasColumnName("ID_veduci");

                entity.Property(e => e.Nazov).HasMaxLength(50);

                entity.HasOne(d => d.IdPatriPodNavigation)
                    .WithMany(p => p.Projekty)
                    .HasForeignKey(d => d.IdPatriPod)
                    .HasConstraintName("FK_Projekty_Divizie");

                entity.HasOne(d => d.IdVeduciNavigation)
                    .WithMany(p => p.Projekty)
                    .HasForeignKey(d => d.IdVeduci)
                    .OnDelete(DeleteBehavior.SetNull)
                    .HasConstraintName("FK_Projekty_Zamestnanci");
            });

            modelBuilder.Entity<Zamestnanci>(entity => {
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
