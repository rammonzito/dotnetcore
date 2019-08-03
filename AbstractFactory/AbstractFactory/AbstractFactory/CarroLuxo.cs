using System;
using System.Collections.Generic;
using System.Text;

namespace AbstractFactory
{
    public class CarroLuxo : CarroFactory
    {
        public override Som MontarSom()
        {
            return new BluetoothPlayer();
        }
        public override Roda MontarRoda()
        {
            return new RodaLigaLeve();
        }
    }
}
