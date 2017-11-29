using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucMx.IOC.Test
{
    public  static class ConfigureContainer
    {
        public static LucIocContainer Configure(this LucIocContainer container)
        {
            container.Register<IMamifero, Mamifero>();
            container.Register<IPerro, Perro>();
            container.Register<IGato, Gato>();
            container.Register<ITigre, Tigre>();

            return container;
        }
    }
}
