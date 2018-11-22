using System;
using System.Collections.Generic;

namespace Acoplamento {
    public class GeradorDeNotaFiscal {
        private IList<IRegraExecucao> acoes;
        public GeradorDeNotaFiscal (IList<IRegraExecucao> acoes) {
            this.acoes = acoes;
        }
        public void Gera(Fatura fatura){
            NotaFiscal nf = new NotaFiscal();
            foreach (var acao in acoes)
            {
                acao.ExecutaAcao(nf);
            }

        }
    }
}