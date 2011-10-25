using System.Collections.Generic;

namespace Exercicio3.Implementacao
{
    public class ProcessadorDeBoletos
    {

        public void processa(IList<Boleto> boletos, Fatura fatura)
        {
            foreach (Boleto boleto in boletos)
            {
                Pagamento pagamento = new Pagamento(boleto.Valor, MeioDePagamento.BOLETO);
                fatura.Pagamentos.Add(pagamento);
            }
        }
    }
}