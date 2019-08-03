using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class WonderWoman : IPersonagem
    {
        public string Escolhido()
        {
            return "Diana";
        }
    }
}
