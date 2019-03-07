using System;
using Microsoft.EntityFrameworkCore;

namespace _05_Escuela.NetCore.Models
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<Carrera> Carreras { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db/udo.db");
            base.OnConfiguring(optionsBuilder);
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Carrera>(carrera => {
                carrera.HasIndex(c => new { c.Nombre, c.Plan }).IsUnique();
                carrera.Property(c => c.Plan)
                       .HasConversion(
                           p => p.ToString(),
                           p => (Plan)Enum.Parse(typeof(Plan), p)
                       );

                // carrera.HasMany(c => c.Materias).WithOne(m => m.Carrera);
                // carrera.HasMany(c => c.Alumnos).WithOne(a => a.Carrera);
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}