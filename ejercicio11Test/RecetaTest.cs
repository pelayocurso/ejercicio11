using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio11;

namespace ejercicio11Test
{
    [TestClass]
    public class RecetaTest
    {
        [TestMethod]
        public void TestValidarAlimentos()
        {
            IReceta sut = new Receta();
            Alimento ali_uno = new Alimento("chope", 1, false);
            Alimento ali_dos = new Alimento("mortadela", 1, false);
            Assert.IsTrue(sut.ValidarAlimentos(ali_uno, ali_dos));
        }

        [TestMethod]
        public void TestEquals()
        {
            Alimento ali_uno = new Alimento("chope", 1, false);
            Alimento ali_dos = new Alimento("mortadela", 1, false);
            IReceta sut = new Receta(ali_uno, ali_dos);

            Assert.IsTrue(
                sut.Equals(new Receta(ali_uno, ali_dos))
            );
        }
    }
}
