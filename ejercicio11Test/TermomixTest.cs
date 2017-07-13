using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio11;
using Moq;

namespace ejercicio11Test
{
    [TestClass]
    public class TermomixTest
    {
        [TestMethod]
        public void TestPesarYCocinar()
        {

            var mockPesoService = new Mock<IPeso>();
            var mockCocinaService = new Mock<ICocina>();

            mockPesoService.Setup(peso => peso.Pesar(It.IsAny<Alimento>()))
                .Returns((Alimento p) => p.peso);
            mockPesoService.Setup(peso => peso.Pesar(It.IsAny<Alimento>()))
                .Returns((Alimento p) => p.peso);

            mockCocinaService.Setup(cocina => cocina.Cocinar(It.IsAny<Alimento>(), It.IsAny<Alimento>()))
                .Callback((Alimento a1, Alimento a2) =>
                {
                    a1.cocinado = true;
                    a2.cocinado = true;
                });

            IPeso pesoService = mockPesoService.Object;
            ICocina cocinaService = mockCocinaService.Object;

            Termomix sut = Termomix.Instance;

            sut.peso = pesoService;
            sut.cocina = cocinaService;

            Alimento ali_uno = new Alimento();
            Alimento ali_dos = new Alimento();

            Plato plato_uno = sut.PesarYCocinar(ali_uno, ali_dos);
            // Plato plato_uno = sut.Cocinar(ali_uno, ali_dos); // Ejemplo de error en el que no hace dos Pesar()

            Alimento ali_tres = new Alimento("chope", 0, true);
            Alimento ali_cuatro = new Alimento("chope", 0, true);
            Plato plato_dos = new Plato(ali_tres, ali_cuatro);

            mockPesoService.Verify(peso => peso.Pesar(It.IsAny<Alimento>()), Times.AtLeast(2));
            mockCocinaService.Verify(cocina => cocina.Cocinar(It.IsAny<Alimento>(), It.IsAny<Alimento>()), Times.AtLeastOnce);

            Assert.IsTrue(
                plato_uno.Equals(plato_dos)
            );
            /*Assert.IsFalse(
                new Plato(null, new Alimento(0, true)).Equals(plato)
            );*/
        }
    }
}
