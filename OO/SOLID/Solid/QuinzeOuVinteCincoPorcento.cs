using System;

namespace Solid
{
    public class QuinzeOuVinteCincoPorcento : IRegraDeCalculo
    {
        public double Calcula(Funcionario funcionario){
            if (funcionario.SalarioBase > 2000.0)
            {
                return funcionario.SalarioBase * 0.75;
            }else
            {
                return funcionario.SalarioBase * 0.85;
            }
            throw new Exception("Funcionário inválido");
        }
    }
}