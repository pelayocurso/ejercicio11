using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio11;

namespace ejercicio11Test
{
    [TestClass]
    public class PlatoTest
    {
        [TestMethod]
        public void TestEquals1()
        {
            Alimento ali_uno = new Alimento();
            Alimento ali_dos = new Alimento();
            Plato sut = new Plato(ali_uno, ali_dos);
            Plato test = new Plato(ali_uno, ali_dos);
            Assert.IsTrue(sut.Equals(test));
        }

        [TestMethod]
        public void TestEquals2()
        {
            Alimento ali_uno = new Alimento();
            Alimento ali_dos = new Alimento();
            Plato sut = new Plato(ali_uno, ali_dos);
            Alimento ali_tres = new Alimento();
            Alimento ali_cuatro = new Alimento();
            Plato test = new Plato(ali_tres, ali_cuatro);
            Assert.IsTrue(sut.Equals(test));
        }
    }
}
