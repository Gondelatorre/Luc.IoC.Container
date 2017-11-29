using System;
using System.Collections.Generic;
using System.Linq;
using System.Runtime.CompilerServices;
using System.Text;
using System.Threading.Tasks;
using LucMx.IOC.Test.Animales;

namespace LucMx.IOC.Test
{
    class Program
    {
        static void Main(string[] args)
        {
            try
            {
                LucIocContainer container = new LucIocContainer();

                Configure(container);


                Console.WriteLine(((IAnimal)container.Resolve<IPerro>()).ObtenerEspecie());
                Console.WriteLine(((IAnimal)container.Resolve<IGato>()).ObtenerEspecie());
                Console.WriteLine(((IAnimal)container.Resolve<ITigre>()).ObtenerEspecie());

                
            }
            catch (Exception ex)
            {
                Console.Write(string.Format("Ocurrio un error: {0}", ex.Message));
            }

            Console.ReadKey();

        }

        static void Configure( LucIocContainer container)
        {
            container.Register<IMamifero, Mamifero>();
            container.Register<IPerro, Perro>();
            container.Register<IGato, Gato>();
            container.Register<ITigre, Tigre>();
            container.Register<ISalvaje, Salvaje>();
        }
    }
}
