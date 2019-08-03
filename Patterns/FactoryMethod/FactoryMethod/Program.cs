using System;

namespace FactoryMethod
{
    class Program
    {
        static void Main(string[] args)
        {
            Console.WriteLine("Batman | Wonder Woman | Superman");
            Console.WriteLine("Você quer saber a identidade secreta de qual personagem?");
            string escolha = Console.ReadLine();
            var a = new FactoryMethod().EscolherPersonagem(escolha);
            Console.WriteLine(string.Format("A identidade secreta do Superman é {0}", a.Escolhido()));
        }
    }
}
