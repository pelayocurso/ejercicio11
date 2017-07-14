using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio11;
using Moq;

namespace ejercicio11Test
{
    [TestClass]
    public class RecetaServiceTest
    {
        public void TestGuardarReceta()
        {
            var mockRecetaRepository = new Mock<IRepository>();
            IReceta receta = new Receta();

            IRecetaService sut = new RecetaService(mockRecetaRepository.Object);
            sut.Guardar(receta);

            mockRecetaRepository.Verify(recetaRepository => recetaRepository.Create(It.IsAny<Receta>()), Times.Once);
        }
    }
}
