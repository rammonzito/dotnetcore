using System;

namespace Solid
{
    public class DezOuVintePorcento : IRegraDeCalculo
    {
         public double Calcula(Funcionario funcionario)
        {
            if (funcionario.SalarioBase > 3000.0)
            {
                return funcionario.SalarioBase * 0.8;
            }else
            {
                return funcionario.SalarioBase * 0.9;
            }

            throw new Exception("Funcionário inválido.");
        }
    }
}