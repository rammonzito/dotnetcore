using System;

namespace Solid
{
    class Programa
    {
        static void Main(string[] args)
        {
            CalculadoraDeSalario cs = new CalculadoraDeSalario();
            Funcionario funcionario = new Funcionario(new Desenvolvedor(new DezOuVintePorcento()), 2000.0);
            double resultado;
            resultado = cs.Calcula(funcionario);
            Console.WriteLine(string.Format("O Salário Líquido de um {0} é {1}", funcionario.Cargo, resultado));
        }
    }
}