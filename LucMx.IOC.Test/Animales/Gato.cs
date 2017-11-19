using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucMx.IOC.Test
{
    internal interface IGato
    {
         
    }

    public class Gato : IAnimal, IGato
    {
        public string ObtenerEspecie()
        {
            return "gato";
        }

        public string ObtenerCaracteristicas()
        {
            return "les hago creer a los hombres que vivo con ellos, en realidad ellos viven conmigo";
        }
    }
}
