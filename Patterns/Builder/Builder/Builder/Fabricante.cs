using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class Fabricante
    {
        public void Construtor(ICelular celularBuilder)
        {
            celularBuilder.BuildBateria();
            celularBuilder.BuildCamera();
            celularBuilder.BuildSO();
            celularBuilder.BuildTela();
        }
    }
}
