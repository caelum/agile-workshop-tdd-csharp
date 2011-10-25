using System;

namespace Exercicio3.Implementacao
{
    public class Pagamento
    {

        public double Valor { get; set; }
        public MeioDePagamento Forma { get; set; }
             
        public Pagamento(double valor, MeioDePagamento forma)
        {
            this.Valor = valor;
            this.Forma = forma;
        }

        public override bool Equals(Object obj)
        {
            if (!(obj is Pagamento))
            {
                return false;
            }
            Pagamento outro = (Pagamento)obj;
            if (Forma != outro.Forma || Valor != outro.Valor)
            {
                return false;
            }

            return true;
        }

        public override int GetHashCode()
        {
            return base.GetHashCode();
        }

    }
}