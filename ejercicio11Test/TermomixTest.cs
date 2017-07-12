using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio11;

namespace ejercicio11Test
{
    [TestClass]
    public class TermomixTest
    {

        [TestMethod]
        public void TestPesar()
        {
            Termomix sut = Termomix.Instance;
            Alimento ali = new Alimento();
            ali.peso = (float)5.0;
            float peso = sut.Pesar(ali);
            Assert.AreEqual(5.0, peso);
        }

        [TestMethod]
        public void TestCocinar()
        {
            Termomix sut = Termomix.Instance;
            Alimento ali_uno = new Alimento();
            Alimento ali_dos = new Alimento();
            sut.Cocinar(ali_uno, ali_dos);
        }

        [TestMethod]
        public void TestPesarYCocinar()
        {
            Termomix sut = Termomix.Instance;
            Alimento ali_uno = new Alimento();
            Alimento ali_dos = new Alimento();
            Plato plato = sut.PesarYCocinar(ali_uno, ali_dos);

            Assert.IsTrue(
                new Plato(new Alimento(0, true), new Alimento(0, true)).Equals(plato)
            );
            Assert.IsFalse(
                new Plato(null, new Alimento(0, true)).Equals(plato)
            );
        }
    }
}
