using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;

namespace Exercicio1.Implementacao
{

    public class Funcionario
    {

        public int Id { get; set; }
        public String Nome { get; set; }
        public Cargo Cargo { get; set; }
        public DateTime DataDeAdmissao { get; set; }
        public double SalarioBase { get; set; }

    }
}