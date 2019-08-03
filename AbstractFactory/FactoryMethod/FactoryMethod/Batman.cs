using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class Batman : IPersonagem
    {
        public string Escolhido()
        {
            return "Bruce Wayne";
        }
    }
}
