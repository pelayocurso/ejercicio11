using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio11;

namespace ejercicio11Test
{
    [TestClass]
    public class PesoServiceTest
    {
        [TestMethod]
        public void TestPesar()
        {
            IPeso sut = new PesoService();

            Alimento alimento = new Alimento();
            alimento.peso = (float) 5.0;

            Assert.AreEqual(5.0, sut.Pesar(alimento));
        }
    }
}
