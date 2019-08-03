using System;

namespace Builder
{
    class Program
    {
        static void Main(string[] args)
        {
            Fabricante fabricante = new Fabricante();
            ICelular celularBuild = null;

            celularBuild = new AndroidBuilder();
            fabricante.Construtor(celularBuild);
            Console.WriteLine("Celular construído com sucesso! Dê boas-vindas ao seu novo {0}", celularBuild.Celular.Nome);
            Console.ReadKey();
        }
    }
}
