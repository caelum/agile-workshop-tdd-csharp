namespace Exercicio3.Implementacao
{
    using System;
    using System.Collections.Generic;

    public class Fatura
    {

        public String Cliente { get; private set; }
        public double Valor { get; private set; }
        public IList<Pagamento> Pagamentos { get; private set; }
        public bool Pago { get; set; }

        public Fatura(String cliente, double valor)
        {
            this.Cliente = cliente;
            this.Valor = valor;
            this.Pagamentos = new List<Pagamento>();
            this.Pago = false;
        }


    }
}