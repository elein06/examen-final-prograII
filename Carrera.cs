namespace Entidades
{
    public class Carrera
    {
        public int Id { get; set; }
        public string Name { get; set;}
        public List<Curso> Cursos { get; set; }
    }
}
