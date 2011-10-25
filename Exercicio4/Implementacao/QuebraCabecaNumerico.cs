
using System.Collections.Generic;
using System;

namespace Exercicio4.Implementacao
{
    public class QuebraCabecaNumerico
    {

        private int entrada;
        private int saida;
        private IList<Numero> fila;
        private HashSet<int> visitados;

        public QuebraCabecaNumerico()
        {
            this.fila = new List<Numero>();
            this.visitados = new HashSet<int>();
        }

        public String GeraCaminho(int entrada, int saida)
        {
            this.entrada = entrada;
            this.saida = saida;

            return FormataSaida(BuscaSolucao());
        }

        private Numero BuscaSolucao()
        {

            AdicionaRaizNaFila();

            while (ExistemNumerosNaFila())
            {
                Numero numeroAtual = RemoveDaFila();

                if (EncontrouSaida(numeroAtual)) return numeroAtual;
                AdicionaNaFila(
                    MultiplicaPorDois(numeroAtual),
                    (EhPar(numeroAtual) ? DividePorDois(numeroAtual) : null),
                    SomaDois(numeroAtual)
                );
            }

            return null;
        }

        private bool EhPar(Numero numeroAtual)
        {
            return numeroAtual.Valor % 2 == 0;
        }

        private bool EncontrouSaida(Numero numeroAtual)
        {
            return numeroAtual.Valor == saida;
        }

        private bool ExistemNumerosNaFila()
        {
            return fila.Count != 0;
        }

        private void AdicionaRaizNaFila()
        {
            fila.Add(new Numero(entrada, null));
        }

        private void AdicionaNaFila(params Numero[] numeros)
        {
            foreach (Numero numero in numeros)
            {
                if (numero != null)
                {
                    if (!visitados.Contains(numero.Valor))
                    {
                        fila.Add(numero);
                        visitados.Add(numero.Valor);
                    }
                }
            }
        }

        private String FormataSaida(Numero solucao)
        {
            String resposta = "";
            while (solucao != null)
            {
                resposta = solucao.Valor + " " + resposta;
                solucao = solucao.Pai;
            }
            return resposta;
        }

        private Numero MultiplicaPorDois(Numero numero)
        {
            return new Numero(numero.Valor * 2, numero);
        }

        private Numero DividePorDois(Numero numero)
        {
            return new Numero(numero.Valor / 2, numero);
        }

        private Numero SomaDois(Numero numero)
        {
            return new Numero(numero.Valor + 2, numero);
        }

        private Numero RemoveDaFila()
        {
            Numero topoDaFila = fila[0];
            fila.RemoveAt(0);
            return topoDaFila;
        }


    }
}