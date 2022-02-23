﻿using DataAccess.Models;
using Microsoft.EntityFrameworkCore;

namespace DataAccess.Data
{
    public partial class RoboGenderContext : DbContext
    {
        public RoboGenderContext()
        {
        }

        public RoboGenderContext(DbContextOptions<RoboGenderContext> options)
            : base(options)
        {
        }

        public virtual DbSet<Weather> Weathers { get; set; } = null!;
        public virtual DbSet<WeatherAverage> WeatherAverages { get; set; } = null!;

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
#warning To protect potentially sensitive information in your connection string, you should move it out of source code. You can avoid scaffolding the connection string by using the Name= syntax to read it from configuration - see https://go.microsoft.com/fwlink/?linkid=2131148. For more guidance on storing connection strings, see http://go.microsoft.com/fwlink/?LinkId=723263.
                optionsBuilder.UseSqlServer("Data Source=(localdb)\\MSSQLLocalDB;Initial Catalog=RoboGender;Integrated Security=True");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Weather>(entity =>
            {
                entity.HasKey(e => new { e.Datum, e.Plats })
                    .HasName("PK__weather__57CEE3F82B0E9861");
            });

            modelBuilder.Entity<WeatherAverage>(entity =>
            {
                entity.HasKey(e => new { e.Date, e.Place })
                    .HasName("PK__WeatherA__EF09729F51E9F0EE");
            });

            OnModelCreatingPartial(modelBuilder);
        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}