using Microsoft.EntityFrameworkCore;

namespace _04_OOP_Console_App.Models
{
    public class UdoDbContext : DbContext
    {
        public DbSet<Alumno> Alumnos { get; set; }
        public DbSet<Docente> Docentes { get; set; }
        public DbSet<Materia> Materias { get; set; }
        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Calificacion> Calificaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db/udo.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(alumno => {
                alumno.HasIndex(a => a.Matricula).IsUnique();
                alumno.HasIndex(a => a.CorreoElectronico).IsUnique();

                alumno.HasOne(a => a.Carrera).WithMany(c => c.Alumnos);
            });

            modelBuilder.Entity<Carrera>(carrera => {
                carrera.HasIndex(c => new { c.Nombre, c.Plan }).IsUnique();

                carrera.HasMany(c => c.Materias).WithOne(m => m.Carrera);
                carrera.HasMany(c => c.Alumnos).WithOne(a => a.Carrera);
            });
            
        }
    }
}