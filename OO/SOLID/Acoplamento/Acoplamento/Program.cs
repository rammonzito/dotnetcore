using System;
using System.Collections.Generic;

namespace Acoplamento {
    class Program {
        static void Main (string[] args) {
            Console.WriteLine ("Inciando Programa");
            IList<IRegraExecucao> acoes = new List<IRegraExecucao> ();
            acoes.Add (new EnviadorEmail ());
            acoes.Add (new SAP ());
            GeradorDeNotaFiscal gnf = new GeradorDeNotaFiscal (acoes);
            Fatura fatura = new Fatura();
            gnf.Gera(fatura);
        
            Console.ReadKey();
        }
    }
}