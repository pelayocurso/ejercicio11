using System;
using Microsoft.VisualStudio.TestTools.UnitTesting;
using ejercicio11;

namespace ejercicio11Test
{
    [TestClass]
    public class AlimentoTest
    {
        [TestMethod]
        public void TestEquals1()
        {
            Alimento sut = new Alimento();
            Alimento test = new Alimento();

            Assert.IsTrue(sut.Equals(test));
        }

        [TestMethod]
        public void TestEquals2()
        {
            Alimento sut = new Alimento("shope", 1, false);
            Alimento test = new Alimento();

            Assert.IsFalse(sut.Equals(test));
        }

        [TestMethod]
        public void TestEquals3()
        {
            Alimento sut = new Alimento("shope", 0, false);
            Alimento test = new Alimento("chope", 0, false);

            Assert.IsFalse(sut.Equals(test));
        }
    }
}
