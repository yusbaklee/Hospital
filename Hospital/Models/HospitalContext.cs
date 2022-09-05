using System;
using System.Collections.Generic;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Hospital.Models
{
    public partial class HospitalContext : DbContext
    {
        public HospitalContext()
        {
        }

        public HospitalContext(DbContextOptions<HospitalContext> options)
            : base(options)
        {
        }

        public virtual DbSet<School> Schools { get; set; } = null!;
        public virtual DbSet<staff> staff { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=.;Initial Catalog=Hospital;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<School>(entity =>
            {
                entity.ToTable("school");

                entity.Property(e => e.FoundedYear)
                    .HasColumnType("datetime")
                    .HasColumnName("Founded Year");

                entity.Property(e => e.SchoolAddress)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("School Address");

                entity.Property(e => e.SchoolEmail)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("School Email");

                entity.Property(e => e.SchoolName)
                    .HasMaxLength(50)
                    .IsUnicode(false)
                    .HasColumnName("School Name");

                entity.Property(e => e.SchoolPhoneNumber).HasColumnName("School PhoneNumber");
            });

            modelBuilder.Entity<staff>(entity =>
            {
                entity.HasNoKey();

                entity.ToTable("Staff");

                entity.Property(e => e.Gender)
                    .HasMaxLength(10)
                    .IsUnicode(false);

                entity.Property(e => e.PhoneNumber)
                    .HasMaxLength(20)
                    .IsUnicode(false);

                entity.Property(e => e.StaffName).IsUnicode(false);
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
