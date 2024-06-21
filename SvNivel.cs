using Services.MyDbContext;
using Entidades;

namespace Servicios.ServNivel
{
    public class SvNivel : ISvNivel
    {
      private MyContext _myDbContext = default!;

        public SvNivel()
        {
            _myDbContext = new MyContext();
        }

        public Nivel AddNivel(Nivel nivel)
        {
            _myDbContext.Niveles.Add(nivel);
            _myDbContext.SaveChanges();
            return nivel;
        }
    }
}
