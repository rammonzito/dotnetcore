namespace Solid {
    public abstract class Cargo {
        public IRegraDeCalculo Regra { get; private set; }
        public Cargo(IRegraDeCalculo regra){
            this.Regra = regra;
        }
    }
}