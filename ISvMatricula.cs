using Entidades;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Servicios.ServMatricula
{
    public interface ISvMatricula
    {
        public Matricula AddMatricula(Matricula matricula);
        public List<Matricula> AddMatriculas(List<Matricula> matriculas);
        public List<Matricula> GetAllMatriculas();
        public List<Matricula> GetAllMatriculaPorCurso(int IdCurso);
        public List<Matricula> GetAllMatriculaPorCarrera(int IdCarrera);
    }
}
