using Entidades;
using Microsoft.EntityFrameworkCore;
using Services.MyDbContext;
using Servicios.ServCurso;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ServMatricula
{
    public class SvMatricula: ISvMatricula
    {
        private MyContext _myDbcontext = default!;
        private SvCurso _svCurso = default!;
        public SvMatricula()
        {
            _myDbcontext = new MyContext();
            _svCurso = new SvCurso();
        }
        public Matricula AddMatricula(Matricula matricula)
        {
            Curso curso = _myDbcontext.Cursos.Find(matricula.CursoId);
            matricula.Sets(curso);

            _myDbcontext.Matriculas.Add(matricula);
            _myDbcontext.SaveChanges();
            return matricula;
        }

        public List<Matricula> GetAllMatriculas()
        {
            return _myDbcontext.Matriculas.Include(x=>x.Curso).Include(x=>x.Nivel).Include(x=>x.Carrera).Include(x => x.Estudiante).ToList();
        }

        public List<Matricula> AddMatriculas(List<Matricula> matriculas)
        {
            foreach (var item in matriculas)
            {
                Curso curso = _myDbcontext.Cursos.Find(item.CursoId);
                item.Sets(curso);
            }

            _myDbcontext.Matriculas.AddRange(matriculas);
            _myDbcontext.SaveChanges();
            return matriculas;
        }

        public List<Matricula> GetAllMatriculaPorCarrera(int IdCarrera)
        {
            return _myDbcontext.Matriculas.Where(x => x.CarreraId == IdCarrera).Include(x => x.Carrera).ToList();
        }
        
        public List<Matricula> GetAllMatriculaPorCurso(int IdCurso)
        {
            return _myDbcontext.Matriculas.Where(x => x.CursoId == IdCurso).Include(x => x.Curso).ToList();
        }
    }
}
