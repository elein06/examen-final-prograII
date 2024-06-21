using Services.MyDbContext;
using Entidades;

namespace Servicios.ServCurso
{
    public class SvCurso : ISvCurso
    {
        private MyContext _myDbContext = default!;

        public SvCurso()
        {
            _myDbContext = new MyContext();
        }

        public Curso AddCurso(Curso curso)
        {
            _myDbContext.Cursos.Add(curso);
            _myDbContext.SaveChanges();
            return curso;
        }
    }
}
