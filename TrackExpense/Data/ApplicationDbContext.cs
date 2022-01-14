using Microsoft.AspNetCore.Identity.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Text;
using TrackExpense.Models;

namespace TrackExpense.Data
{
    public class ApplicationDbContext : IdentityDbContext
    {
        public DbSet<ExpenseDetail> ExpenseDetails { get; set; }

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<ExpenseDetail>(entity =>
            {
                entity.Property(e => e.UserEmail)
                .IsRequired();

                entity.Property(e => e.Date).HasColumnType("date")
                .IsRequired();

                entity.Property(e => e.ExpenseDescription)
                    .HasMaxLength(250)
                    .IsUnicode(false)
                    .IsRequired();

                entity.Property(e => e.Amount).HasColumnType("Amount")
                .IsRequired();
            });

            OnModelCreatingPartial(modelBuilder);
        }

        void OnModelCreatingPartial(ModelBuilder modelBuilder) { }
    }
}
