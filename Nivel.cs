namespace Entidades
{
    public class Nivel
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public List<Curso> Cursos { get; set; }
    }
}
