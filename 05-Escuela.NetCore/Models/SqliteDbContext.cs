using System;
using Microsoft.EntityFrameworkCore;

namespace _05_Escuela.NetCore.Models
{
    public class SqliteDbContext : DbContext
    {
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Alumno> Alumnos { get; set; }

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
                carrera.HasMany(c => c.Alumnos).WithOne(a => a.Carrera);

                carrera.HasData(new Carrera {
                    Id = 1,
                    Nombre = "Sistemas computacionales",
                    Plan = Plan.Trimestral
                });
            });

            modelBuilder.Entity<Alumno>(alumno => {
                alumno.HasIndex(a => a.Matricula).IsUnique();
                alumno.HasIndex(a => a.CorreoElectronico).IsUnique();

                alumno.HasOne(a => a.Carrera)
                      .WithMany(c => c.Alumnos)
                      .HasForeignKey(a => a.CarreraId);
                
                // alumno.HasMany(a => a.AlumnoCalificaciones)
                //       .WithOne(ac => ac.Alumno);
                
                alumno.Property(a => a.Genero)
                    .HasConversion(
                        g => g.ToString(),
                        g => (Genero)Enum.Parse(typeof(Genero), g)
                    );
                alumno.HasData(new Alumno {
                    Id = 1,
                    Matricula = "9730035",
                    Nombre = "Bidkar",
                    Apellidos = "Aragon",
                    CorreoElectronico = "bidkar@aragon",
                    Genero = Genero.Hombre,
                    CarreraId = 1
                });
            });
            
            base.OnModelCreating(modelBuilder);
        }
    }
}