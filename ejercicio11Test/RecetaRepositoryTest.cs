using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio11;

namespace ejercicio11Test
{
    [TestClass]
    public class RecetaRepositoryTest
    {
        [TestMethod]
        public void TestCreate()
        {
            IRepository repository = new RecetaRepository();
            IReceta receta = new Receta();

            repository.Create(receta);
            Assert.AreSame(receta, repository.Read(0));
        }
    }
}
