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
            AlimentoPrueba ali = new AlimentoPrueba();
            double peso = sut.Pesar(ali);
            Assert.AreEqual(5.0, peso);
        }

        [TestMethod]
        public void TestCocinar()
        {
            Termomix sut = Termomix.Instance;
            AlimentoPrueba ali_uno = new AlimentoPrueba();
            AlimentoPrueba ali_dos = new AlimentoPrueba();
            sut.Cocinar(ali_uno, ali_dos);
        }

        [TestMethod]
        public void TestPesarYCocinar()
        {
            Termomix sut = Termomix.Instance;
            AlimentoPrueba ali_uno = new AlimentoPrueba();
            AlimentoPrueba ali_dos = new AlimentoPrueba();
            sut.PesarYCocinar(ali_uno, ali_dos);
        }
    }

    public class AlimentoPrueba : IAlimento
    {
        public double peso
        {
            get
            {
                return 5.0;
            }

            set
            {
                this.peso = peso;
            }
        }
    }
}
