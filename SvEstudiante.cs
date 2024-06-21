using Entidades;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;


namespace Servicios.ServEstudiante
{
    public class SvEstudiante : ISvEstudiante
    {
        private MyContext _myDbConext = default!;

        public SvEstudiante()
        {
            _myDbConext = new MyContext();
        }

        public Estudiante addStudent(Estudiante estudiante)
        {
            _myDbConext.Estudiantes.Add(estudiante);
            _myDbConext.SaveChanges();

            return estudiante;
        }
    }
}
