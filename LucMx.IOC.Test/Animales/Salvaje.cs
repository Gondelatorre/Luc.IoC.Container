using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucMx.IOC.Test.Animales
{
    public class Salvaje: IAnimal, ISalvaje
    {
       
        public Salvaje()
        {
           
        }

        public string ObtenerEspecie()
        {
            return "soy salvaje ";
        }

        public string ObtenerCaracteristicas()
        {
            return "No acostumbro a estar con personas";
        }
    }
}
