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
        // public DbSet<AlumnoCalificaciones> AlumnoCalificaciones { get; set; }

        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseSqlite("Data Source=Db/udo.db");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.Entity<Alumno>(alumno => {
                alumno.HasIndex(a => a.Matricula).IsUnique();
                alumno.HasIndex(a => a.CorreoElectronico).IsUnique();

                alumno.HasOne(a => a.Carrera)
                      .WithMany(c => c.Alumnos)
                      .HasForeignKey(a => a.CarreraId);
                
                alumno.HasMany(a => a.AlumnoCalificaciones)
                      .WithOne(ac => ac.Alumno);
            });

            modelBuilder.Entity<Carrera>(carrera => {
                carrera.HasIndex(c => new { c.Nombre, c.Plan }).IsUnique();

                carrera.HasMany(c => c.Materias).WithOne(m => m.Carrera);
                carrera.HasMany(c => c.Alumnos).WithOne(a => a.Carrera);
            });

            modelBuilder.Entity<Materia>(materia => {
                materia.HasOne(m => m.Carrera)
                       .WithMany(c => c.Materias)
                       .HasForeignKey(m => m.CarreraId);
            });

            modelBuilder.Entity<Docente>(docente => {
                docente.HasIndex(d => d.Rfc).IsUnique();
            });

            modelBuilder.Entity<Calificacion>(cal => {
                cal.HasIndex(c => new { c.AlumnoId, c.DocenteId, c.MateriaId, c.Periodo }).IsUnique();

                cal.HasMany(c => c.AlumnoCalificaciones).WithOne(ac => ac.Calificacion);
            });
            
            modelBuilder.Entity<AlumnoCalificaciones>(alucal => {
                alucal.HasKey(ac => new { ac.AlumnoId, ac.CalificacionId });

                alucal.HasOne(ac => ac.Alumno).WithMany(a => a.AlumnoCalificaciones);
                alucal.HasOne(ac => ac.Calificacion).WithMany(a => a.AlumnoCalificaciones);
            });
        }
    }
}