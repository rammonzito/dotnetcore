using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CarroSimples : CarroFactory
    {
        public override Som MontarSom()
        {
            return new CDPlayer();
        }
        public override Roda MontarRoda()
        {
            return new RodaSimples();
        }
    }
}
