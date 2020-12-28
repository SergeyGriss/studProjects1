using System;
using Database.EFCore.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata;

namespace Database.EFCore
{
    public partial class NoteContext : DbContext
    {
        public DbSet<NoteEntity> Notes { get; set; }
        
        public NoteContext()
        {
        }

        public NoteContext(DbContextOptions<NoteContext> options)
            : base(options)
        {
        }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            if (!optionsBuilder.IsConfigured)
            {
                optionsBuilder.UseNpgsql("Host=localhost;Port=5432;Database=postgres;User ID=postgres;Password=postgres;");
            }
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            OnModelCreatingPartial(modelBuilder);

            modelBuilder.Entity<NoteEntity>(entity =>
            {
                entity.ToTable("Notes");
                entity.HasKey(x => x.id);
                entity.Property(x => x.id).UseIdentityColumn();
                entity.Property(x => x.id).UseIdentityColumn();
            });
            //modelBuilder.Entity<NoteEntity>().HasData(new NoteEntity { id = 1, dateTime = DateTime.Now, text = "Text sample", user = "SS" });

            modelBuilder.Entity<NoteEntity>().HasData(new NoteEntity(1, DateTime.Now, "Text sample", "SS"));
            modelBuilder.Entity<NoteEntity>().HasData(new NoteEntity(2, DateTime.Now, "Second text sample", "SS"));
            modelBuilder.Entity<NoteEntity>().HasData(new NoteEntity(3, DateTime.Now, "Third text sample", "KC"));

        }

        partial void OnModelCreatingPartial(ModelBuilder modelBuilder);
    }
}
