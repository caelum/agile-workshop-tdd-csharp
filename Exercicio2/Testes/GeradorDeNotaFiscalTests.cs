using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using NUnit.Framework;
using Exercicio2.Implementacao;
using Moq;

namespace Exercicio2.Testes
{
    public class GeradorDeNotaFiscalTests
    {

        private static double PRECISAO = 0.00001;
        private Mock<EnviadorDeEmail> email;
        private Mock<NotaFiscalDao> dao;
        private GeradorDeNotaFiscal gerador;

        [SetUp]
        public void SetUp()
        {
            email = new Mock<EnviadorDeEmail>();
            dao = new Mock<NotaFiscalDao>();

            gerador = new GeradorDeNotaFiscal(email.Object, dao.Object);
        }

        [Test]
        public void DeveGerarNotaCom6PorCentoDeImposto()
        {
            Fatura fatura = new Fatura(1000, "cliente 1");

            NotaFiscal nf = gerador.Gera(fatura);

            Assert.AreEqual(1000 * 0.06, nf.Impostos, PRECISAO);
        }

        [Test]
        public void DeveEnviarEmailComANotaFiscal()
        {

            Fatura fatura = new Fatura(1000, "cliente 1");
            NotaFiscal nf = gerador.Gera(fatura);

            email.Verify(e => e.EnviaEmail(nf));
        }

        [Test]
        public void DevePersistirANotaFiscalGerada()
        {
            Fatura fatura = new Fatura(1000, "cliente 1");

            NotaFiscal nf = gerador.Gera(fatura);

            dao.Verify(e => e.Persiste(nf));
        }
    }
}
