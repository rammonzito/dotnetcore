using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Praticando.Linq {
  class Produto {
	private List<Produto> listaProdutos;
	public Produto() {
	  listaProdutos = new List<Produto>();
	}
	public List<Produto> Listar() {
	  listaProdutos.Add(new Produto { Nome = "Café", Valor = 8, ID = Guid.NewGuid() });
	  listaProdutos.Add(new Produto { Nome = "Lápis", Valor = 10, ID = Guid.NewGuid() });
	  listaProdutos.Add(new Produto { Nome = "Algodão", Valor = 98, ID = Guid.NewGuid() });
	  return listaProdutos;
	}

	public Guid ID { get; set; }
	public string Nome { get; set; }
	public decimal Valor { get; set; }
  }
}
