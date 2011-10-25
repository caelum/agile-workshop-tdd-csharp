using System;
namespace Exercicio2.Implementacao
{
    public class Fatura
    {

        public double ValorMensal { get; set; }
        public String Cliente { get; set; }
        public Fatura() { }

        public Fatura(double ValorMensal, String Cliente)
        {
            this.ValorMensal = ValorMensal;
            this.Cliente = Cliente;
        }


    }
}