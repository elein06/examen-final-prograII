 namespace Entidades
{
    public class Matricula
    {
        public int Id { get; set; }
        public int EstudianteId { get; set; }
        public int CarreraId { get; private set; }
        public int CursoId { get; set; }
        public Estudiante Estudiante { get; set; }
        public Carrera Carrera { get; set; }
        public Curso Curso { get; set; }

        public void setIdCarrera(Curso curso)
        {
            this.CarreraId = curso.idCarrera;
        }
    }
}
