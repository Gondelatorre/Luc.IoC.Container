using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucMx.IOC.Test.Animales;

namespace LucMx.IOC.Test
{
    internal interface ITigre
    {
        
    }

    public class Tigre:IAnimal, ITigre
    {

        private ISalvaje _salvaje;
        public Tigre(ISalvaje salvaje)
        {
            _salvaje = salvaje;
        }

        public string ObtenerEspecie()
        {
            return "tigre " + _salvaje.ObtenerEspecie();
        }

        public string ObtenerCaracteristicas()
        {
            return "yo me como a los hombres";
        }
    }
}
