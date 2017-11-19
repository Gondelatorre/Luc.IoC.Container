using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucMx.IOC.Test
{
    public interface IPerro
    {
         
    }

    public class Perro : IAnimal, IPerro
    {
        private IMamifero _mamifero;

        public Perro(IMamifero mamifero)
        {
            _mamifero = mamifero;
        }

        public string ObtenerEspecie()
        {
            return "perro, " + _mamifero.ObtenerMensaje();
        }

        public string ObtenerCaracteristicas()
        {
            return "mejor amigo del hombre";
        }
    }
}
