using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class ExecuteAbstractFactory
    {
        public static Carro MontaCarro(string tipo)
        {
            CarroFactory c = null;
            switch (tipo)
            {
                case "luxo":
                    c = new CarroLuxo();
                    break;
                case "popular":
                    c = new CarroSimples();
                    break;
            }
            Carro carro = new Carro();
            carro.Roda = c.MontarRoda();
            carro.Som = c.MontarSom();
            return carro;
        }
    }
}