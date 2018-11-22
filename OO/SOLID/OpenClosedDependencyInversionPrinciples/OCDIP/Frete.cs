using System;
namespace OCDIP {
    public class Frete : IServicoDeEntrega {
        public double Para (string cidade) {
            if ("São Paulo".Equals (cidade.ToUpper ())) {
                return 15;
            }
            return 30;
        }
    }
}