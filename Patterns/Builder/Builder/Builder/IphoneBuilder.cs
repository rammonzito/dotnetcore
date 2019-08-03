using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class IphoneBuilder : ICelular
    {
        Celular celular;

        public IphoneBuilder()
        {
            celular = new Celular("Iphone");
        }

        public void BuildBateria()
        {
            this.celular.bateria = "JJ_3000";
        }

        public void BuildCamera()
        {
            this.celular.camera = "40 MP";
        }

        public void BuildSO()
        {
            this.celular.bateria = "IOS 12";
        }

        public void BuildTela()
        {
            this.celular.bateria = "10\"";
        }

        public Celular Celular {
            get { return this.celular; }
        }
    }
}
