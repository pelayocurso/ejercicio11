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
            Alimento ali = new Alimento("chope", 1, true);

            Assert.AreEqual(1, sut.Pesar(ali));
        }

        public void TestCocinar()
        {
            Termomix sut = Termomix.Instance;
            Alimento ali_uno = new Alimento("chope", 1, false);
            Alimento ali_dos = new Alimento("chope", 1, false);
            Plato plato = sut.Cocinar(ali_uno, ali_dos);

            Assert.IsTrue(ali_uno.cocinado);

            Alimento ali_tres = new Alimento("chope", 1, true);
            Alimento ali_cuatro = new Alimento("chope", 1, true);
            Plato test = new Plato(ali_tres, ali_cuatro);

            Assert.IsTrue(
                plato.Equals(test)
            );
        }

        public void TestValidar()
        {
            Termomix sut = Termomix.Instance;
            Alimento ali_uno = new Alimento("chope", 1, false);
            Alimento ali_dos = new Alimento("chope", 1, false);

            Assert.IsTrue(sut.Validar(ali_uno, ali_dos));
        }

        [TestMethod]
        public void TestPesarYCocinar()
        {
            Termomix sut = Termomix.Instance;
            Alimento ali_uno = new Alimento();
            Alimento ali_dos = new Alimento();

            Plato plato_uno = sut.PesarYCocinar(ali_uno, ali_dos);

            Alimento ali_tres = new Alimento("chope", 0, true);
            Alimento ali_cuatro = new Alimento("chope", 0, true);
            Plato plato_dos = new Plato(ali_tres, ali_cuatro);

            Assert.IsTrue(
                plato_uno.Equals(plato_dos)
            );
            /*Assert.IsFalse(
                new Plato(null, new Alimento(0, true)).Equals(plato)
            );*/
        }

        [TestMethod]
        public void TestValidarYCocinar()
        {
            Termomix sut = Termomix.Instance;
            Alimento ali_uno = new Alimento("chope", 1, false);
            Alimento ali_dos = new Alimento("chope", 1, false);

            Plato plato = sut.ValidarYCocinar(ali_uno, ali_dos);

            Assert.IsTrue(
                plato.Equals(new Plato(new Alimento("chope", 1, true), new Alimento("chope", 1, true)))
            );
            /*Assert.IsFalse(
                new Plato(null, new Alimento(0, true)).Equals(plato)
            );*/
        }
    }
}
