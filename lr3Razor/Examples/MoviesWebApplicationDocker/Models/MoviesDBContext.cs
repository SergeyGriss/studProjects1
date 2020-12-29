using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using Microsoft.EntityFrameworkCore.Metadata;

namespace MoviesWebApplication.Models
{
    public partial class MoviesDBContext : DbContext
    {
        public DbSet<Movies> Movies { get; set; }
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=postgres;Port=5432;Database=postgres;User ID=postgres;Password=root;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<Movies>(entity =>
            {
                entity.ToTable("Movies");
                entity.HasKey(x => x.MoviesId);
                entity.Property(x => x.MoviesId).UseIdentityColumn();
                entity.Property(x => x.MoviesId).UseIdentityColumn();
            });


            modelBuilder.Entity<Movies>().HasData(new Movies { MoviesId = 1, Name = "First Title", Year = 1990});
            modelBuilder.Entity<Movies>().HasData(new Movies { MoviesId = 2, Name = "Second Title", Year = 2000});
            modelBuilder.Entity<Movies>().HasData(new Movies { MoviesId = 3, Name = "Third Title", Year = 2020});



        }
        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}

