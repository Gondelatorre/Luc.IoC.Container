using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucMx.IOC.Test
{
    public class Mamifero : IMamifero
    {
        public string ObtenerMensaje()
        {
            return "soy un mamifero";
        }
    }
}
