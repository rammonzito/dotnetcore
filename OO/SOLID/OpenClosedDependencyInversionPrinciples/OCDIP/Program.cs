using System;

namespace OCDIP {
    class Program {
        static void Main (string[] args) {
          Compra compra = new Compra(500, "São Paulo");
          CalculadoraDePrecos calc = new CalculadoraDePrecos(new TabelaDePrecos(), new Transportadora());

          double resultado = calc.Calcula(compra);

          Console.WriteLine("O preço da compra é:" + resultado);

        }
    }
}