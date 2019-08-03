using System;

namespace AbstractFactory
{
    class Program
    {
        static void Main(string[] args)
        {
            Carro carro = ExecuteAbstractFactory.MontaCarro("luxo");
            Carro carro2 = ExecuteAbstractFactory.MontaCarro("popular");

            Console.ReadKey();
        }
    }
}
