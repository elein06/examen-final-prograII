using Entidades;
using Services.MyDbContext;

namespace Servicios.ServCarrera
{
    public class SvCarrera : ISvCarrera
    {
        private MyContext _myDbContext = default!;
        public SvCarrera()
        {
            _myDbContext = new MyContext();
        }
        public Carrera AddCarrera(Carrera carrera)
        {
            _myDbContext.Carreras.Add(carrera);
            _myDbContext.SaveChanges();
            return carrera;
        }
    }
}
