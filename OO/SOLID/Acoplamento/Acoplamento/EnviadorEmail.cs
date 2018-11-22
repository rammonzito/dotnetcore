using System;
using System.Collections.Generic;

namespace Acoplamento
{
    public class EnviadorEmail : IRegraExecucao
    {
        public void ExecutaAcao(NotaFiscal notaFiscal){
            Console.WriteLine("Enviando Email");
        }
    }
}