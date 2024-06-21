
namespace Entidades
{
    public class Curso
    {
        public int Id { set; get; }
        public string Name { get; set; }
        public List<Estudiante> Estudiantes { get; set; }
        public int idCarrera { get; set; }
        public int idNivel { get; set; }
        public Carrera Carrera { get; set; }
        public Nivel Nivel { get; set; }
    }
}
