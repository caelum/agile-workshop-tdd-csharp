
using NUnit.Framework;
using Exercicio4.Implementacao;

namespace Exercicio4.Testes
{
    public class QuebraCabecaNumericoTests
    {

        [Test]
        public void TestaEntrada2ESaida2()
        {
            Assert.AreEqual("2 ", new QuebraCabecaNumerico().GeraCaminho(2, 2));
        }

        [Test]
        public void TestaEntrada2ESaida4()
        {
            Assert.AreEqual("2 4 ", new QuebraCabecaNumerico().GeraCaminho(2, 4));
        }

        [Test]
        public void TestaEntrada2ESaida8()
        {
            Assert.AreEqual("2 4 8 ", new QuebraCabecaNumerico().GeraCaminho(2, 8));
        }

        [Test]
        public void TestaEntrada2ESaida10()
        {
            Assert.AreEqual("2 4 8 10 ", new QuebraCabecaNumerico().GeraCaminho(2, 10));
        }

        [Test]
        public void TestaEntrada3ESaida10()
        {
            Assert.AreEqual("3 5 10 ", new QuebraCabecaNumerico().GeraCaminho(3, 10));
        }

        [Test]
        public void TestaEntrada2ESaida9()
        {
            Assert.AreEqual("2 4 8 16 18 9 ", new QuebraCabecaNumerico().GeraCaminho(2, 9));
        }

        [Test]
        public void TestaEntra9ESaida2()
        {
            Assert.AreEqual("9 18 20 10 12 6 8 4 2 ", new QuebraCabecaNumerico().GeraCaminho(9, 2));
        }

        [Test]
        public void TestaEntra3ESaida11()
        {
            Assert.AreEqual("3 5 7 9 11 ", new QuebraCabecaNumerico().GeraCaminho(3, 11));
        }
    }
}