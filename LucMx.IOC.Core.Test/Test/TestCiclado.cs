using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace LucMx.IOC.Core.Test.Test
{
    public class TestCiclado : ITestCiclado
    {
        public TestCiclado(ITestCiclado testCiclado)
        {
            
        }

        public void TestMethod()
        {
            //do nothing
        }
    }
}
