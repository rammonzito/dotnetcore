using System;
using System.Collections.Generic;
using System.Text;

namespace Builder
{
    public class AndroidBuilder : ICelular
    {
        Celular celular;
        public AndroidBuilder()
        {
            celular = new Celular("Android");
        }

        public void BuildBateria()
        {
            this.celular.bateria = "MAH_1500";
        }

        public void BuildCamera()
        {
            this.celular.camera = "20 MP";
        }

        public void BuildSO()
        {
            this.celular.so = "Android Lollipop";
        }

        public void BuildTela()
        {
            this.celular.tela = "10\"";
        }

        public Celular Celular
        {
            get { return this.celular; }
        }
    }
}
