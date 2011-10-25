namespace Exercicio4.Implementacao
{

    public class Numero
    {
        public int Valor { get; private set; }
        public Numero Pai { get; private set; }

        public Numero(int valor, Numero pai)
        {
            this.Valor = valor;
            this.Pai = pai;
        }
    }
}