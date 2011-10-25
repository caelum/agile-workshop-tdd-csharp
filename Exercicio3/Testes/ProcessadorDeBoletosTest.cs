
using NUnit.Framework;
using System.Collections.Generic;
using Exercicio3.Implementacao;
public class ProcessadorDeBoletosTest {

	[Test]
	public void NaoDeveGerarPagamentosQuandoNaoHaBoletos() {
		Fatura f = new Fatura("sun", 1000.0);
		IList<Boleto> boletosPagos = new List<Boleto>();

		new ProcessadorDeBoletos().processa(boletosPagos, f);
		
		Assert.AreEqual(0, f.Pagamentos.Count);
	}
	
	[Test]
	public void DeveGerarUmPagamentoDeBoletoParaAFatura() {
		Fatura f = new Fatura("sun", 1000.0);
		List<Boleto> boletosPagos = new List<Boleto>(new Boleto[] {new Boleto(200.0), new Boleto(500.0)});
		
		new ProcessadorDeBoletos().processa(boletosPagos, f);
		
		Assert.AreEqual(2, f.Pagamentos.Count);
		Assert.AreEqual(new Pagamento(200.0, MeioDePagamento.BOLETO), f.Pagamentos[0]);
		Assert.AreEqual(new Pagamento(500.0, MeioDePagamento.BOLETO), f.Pagamentos[1]);
	}
}
