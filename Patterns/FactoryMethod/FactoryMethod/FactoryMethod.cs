using System;
using System.Collections.Generic;
using System.Text;

namespace FactoryMethod
{
    public class FactoryMethod
    {
        public IPersonagem EscolherPersonagem(string personagem)
        {
            switch (personagem)
            {
                case "Batman":
                    return new Batman();
                case "Wonder Woman":
                    return new WonderWoman();
                case "Superman":
                    return new Superman();
                default:
                    return null;
            }
        }
    }
}
