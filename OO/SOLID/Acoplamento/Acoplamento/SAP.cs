using System;
using System.Collections.Generic;

namespace Acoplamento {
    public class SAP : IRegraExecucao {
        public void ExecutaAcao (NotaFiscal nf) {
            Console.WriteLine ("Envia NF para o SAP");
        }
    }
}