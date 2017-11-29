using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using LucMx.IOC.Core.Test.Test;
using NUnit.Framework;

namespace LucMx.IOC.Core.Test
{
    [TestFixture]
    public class LucIocContainerUnitTest
    {
        private LucIocContainer _container;

        [SetUp]
        public void SetUp()
        {
            _container = LucIocContainer.GetNewContainer();
            _container.Register<ITest, Test.Test>();
        }

        [TearDown]
        public void TearDown()
        {

        }


        [Test]
        public void RegisterTest()
        {

            var res = _container.Resolve<ITest>();

            Assert.NotNull(res, "No se logró resolver instancia de Test");
        }

        [Test]
        public void ResolverInstanciaNoRegistradaTest()
        {
            try
            {
               var res = _container.Resolve<ITestNoRegistrada>();

                Assert.Fail("Si resolvio");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("ITestNoRegistrada"), "Se esperaba error al resolver ITestNoRegistrada");
            }

        }

        [Test]
        public void ReferenciaCiclicaErrorTest()
        {
            try
            {
                _container.Register<ITestCiclado, TestCiclado>();

                var res = _container.Resolve<ITestCiclado>();
                Assert.Fail("Si resolvio");
            }
            catch (Exception ex)
            {
                Assert.IsTrue(ex.Message.Contains("Problema de referencia ciclica"), "Se esperaba error al resolver ITestCiclado");
            }

        }


    }
}
