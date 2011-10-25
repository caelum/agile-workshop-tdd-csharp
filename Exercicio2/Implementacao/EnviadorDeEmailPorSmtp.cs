using System;
namespace Exercicio2.Implementacao
{
    public class EnviadorDeEmailPorSmtp : EnviadorDeEmail
    {

        public void EnviaEmail(NotaFiscal nf)
        {
            Console.WriteLine("envia email da nf " + nf.Id);
        }

    }
}