using System;

namespace Exercicio1.Implementacao
{

    public class CalculadoraDeSalario {

	    public double Calcula(Funcionario funcionario) {
		    if(Cargo.DESENVOLVEDOR.Equals(funcionario.Cargo)) {
			    return DezOuVintePorCentoDeDescontoNo(funcionario);
		    }
		
		    if(Cargo.DBA.Equals(funcionario.Cargo) || Cargo.TESTADOR.Equals(funcionario.Cargo)) {
			    return QuinzeOuVinteECincoPorCentoDeDescontoNo(funcionario);
		    }
		
		    throw new Exception("funcionario invalido");
	    }

	    private double DezOuVintePorCentoDeDescontoNo(Funcionario funcionario) {
		    if(funcionario.SalarioBase > 3000.0) {
			    return funcionario.SalarioBase * 0.8;
		    }
		    else {
			    return funcionario.SalarioBase * 0.9;
		    }
	    }

	    private double QuinzeOuVinteECincoPorCentoDeDescontoNo(Funcionario funcionario) {
		    if(funcionario.SalarioBase > 2000.0) {
			    return funcionario.SalarioBase * 0.75;
		    }
		    else {
			    return funcionario.SalarioBase * 0.85;
		    }
	    }

    }

}
