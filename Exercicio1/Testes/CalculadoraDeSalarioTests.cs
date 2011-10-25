using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using Exercicio1.Implementacao;
using NUnit.Framework;

namespace Exercicio1.Testes
{
    public class CalculadoraDeSalarioTests
    {

        private CalculadoraDeSalario calculadora;

        [SetUp]
        public void SetUp()
        {
            calculadora = new CalculadoraDeSalario();
        }

        [Test]
        public void DeveRetornar4000MenosImpostosDe20PorCentoSeDesenvolvedorGanhaMaisDe3000()
        {
            Funcionario desenvolvedor = UmFuncionario(Cargo.DESENVOLVEDOR, ComSalarioBase(4000.0));

            double salario = calculadora.Calcula(desenvolvedor);

            Assert.AreEqual(4000.0 * 0.8, salario, 0.000001);
        }

        [Test]
        public void DeveRetornar1000MenosImpostosDe10PorCentoSeDesenvolvedorGanhaMenosDe3000()
        {
            Funcionario desenvolvedor = UmFuncionario(Cargo.DESENVOLVEDOR, ComSalarioBase(1000.0));

            double salario = calculadora.Calcula(desenvolvedor);

            Assert.AreEqual(1000.0 * 0.9, salario, 0.000001);
        }


        [Test]
        public void DeveRetornar4000MenosImpostosDe25PorCentoSeDBAGanhaMaisDe2000()
        {
            Funcionario dba = UmFuncionario(Cargo.DBA, ComSalarioBase(4000.0));

            double salario = calculadora.Calcula(dba);

            Assert.AreEqual(4000.0 * 0.75, salario, 0.000001);
        }

        [Test]
        public void DeveRetornar1000MenosImpostosDe15PorCentoSeDBAGanhaMenosDe2000()
        {
            Funcionario dba = UmFuncionario(Cargo.DBA, ComSalarioBase(1000.0));

            double salario = calculadora.Calcula(dba);

            Assert.AreEqual(1000.0 * 0.85, salario, 0.000001);
        }

        [Test]
        public void DeveRetornar4000MenosImpostosDe25PorCentoSeTestadorGanhaMaisDe2000()
        {
            Funcionario testador = UmFuncionario(Cargo.TESTADOR, ComSalarioBase(4000.0));

            double salario = calculadora.Calcula(testador);

            Assert.AreEqual(4000.0 * 0.75, salario, 0.000001);
        }

        [Test]
        public void DeveRetornar1000MenosImpostosDe15PorCentoSeTestadorGanhaMenosDe2000()
        {
            Funcionario testador = UmFuncionario(Cargo.TESTADOR, ComSalarioBase(1000.0));

            double salario = calculadora.Calcula(testador);

            Assert.AreEqual(1000.0 * 0.85, salario, 0.000001);
        }


        private Funcionario UmFuncionario(Cargo cargo, double salario)
        {
            Funcionario funcionario = new Funcionario();
            funcionario.Nome = "Martin Fowler";
            funcionario.SalarioBase = salario;
            funcionario.Cargo = cargo;
            return funcionario;
        }


        private double ComSalarioBase(double salario)
        {
            return salario;
        }
    }
}
