using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio11;

namespace ejercicio11Test
{
    [TestClass]
    public class CocinaServiceTest
    {
        [TestMethod]
        public void TestCocinar()
        {
            ICocina sut = new CocinaService();
            Alimento uno = new Alimento();
            Alimento dos = new Alimento();

            sut.Cocinar(uno, dos);

            Assert.IsTrue(uno.cocinado && dos.cocinado);
        }
    }
}
