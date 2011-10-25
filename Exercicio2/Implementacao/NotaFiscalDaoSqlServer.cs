using System;
namespace Exercicio2.Implementacao
{
    public class NotaFiscalDaoSqlServer : NotaFiscalDao
    {

        public void Persiste(NotaFiscal nf)
        {
            Console.WriteLine("salva nf no banco");
        }

    }
}