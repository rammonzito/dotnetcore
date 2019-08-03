using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Celular
    {
        public string Nome;

        public Celular(string nome)
        {
            Nome = nome;
        }

        //public string nome { get; set; }
        public string tela { get; set; }
        public string bateria { get; set; }
        public string so { get; set; }
        public string camera { get; set; }
    }
}
