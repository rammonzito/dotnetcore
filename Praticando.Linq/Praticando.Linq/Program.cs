using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Newtonsoft.Json;

namespace Praticando.Linq {
  class Program {
	static void Main(string[] args) {
	  //1 com array simples..
	  //int[] numeros = { 1, 2, 3, 4, 5 };

	  //objeto
	  //var produtos = new Produto().Listar();

	  //cláusulas simples
	  // foreach (var item in produtos
	  //.Where(p=> p.Valor > 8)
	  //.Select(p => p.Nome)
	  //) {
	  //Console.WriteLine(item);
	  // }

	  //Select
	  // var resultado =
	  // from prod in produtos
	  // where prod.Nome.Contains("C")
	  // select prod;

	  // foreach (var item in resultado) {
	  //Console.WriteLine(JsonConvert.SerializeObject(item));
	  // }

	  //Console.ReadKey();
	}
  }
}
