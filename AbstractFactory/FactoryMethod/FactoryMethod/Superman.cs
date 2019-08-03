using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Superman : IPersonagem
    {
        public string Escolhido()
        {
            return "Clark Kent";
        }
    }
}
