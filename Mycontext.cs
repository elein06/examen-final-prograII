using Entidades;
using Microsoft.EntityFrameworkCore;

namespace Services.MyDbContext
{
    public class MyContext : DbContext
    {
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            optionsBuilder.UseInMemoryDatabase("MyDatabase");
        }

        public DbSet<Carrera> Carreras { get; set; }
        public DbSet<Estudiante> Estudiantes { get; set; }
        public DbSet<Matricula> Matriculas { get; set; }
        public DbSet<Nivel> Niveles { get; set; }
        public DbSet<Curso> Cursos { get; set; }

        protected override void OnModelCreating(ModelBuilder modelBuilder) 
        { 

            modelBuilder.Entity<Curso>()
              .HasOne(curso => curso.Carrera)
              .WithMany(carrera => carrera.Cursos)
              .HasForeignKey(curso => curso.idCarrera);

        }
    }
}
