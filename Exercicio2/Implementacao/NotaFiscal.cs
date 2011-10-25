namespace Exercicio2.Implementacao
{
    public class NotaFiscal
    {

        public int Id { get; set; }
        public double ValorBruto { get; set; }
        public double Impostos { get; set; }

        public NotaFiscal(int id, double valorBruto, double impostos)
        {
            this.Id = id;
            this.ValorBruto = valorBruto;
            this.Impostos = impostos;
        }

        public NotaFiscal(double valorBruto, double impostos)
            : this(0, valorBruto, impostos)
        {

        }

        public double ValorLiquido
        {
            get
            {
                return this.ValorBruto - this.Impostos;
            }
        }

    }
}