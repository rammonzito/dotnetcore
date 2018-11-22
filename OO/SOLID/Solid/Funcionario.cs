namespace Solid {
    public class Funcionario {
        public Cargo Cargo { get; private set; }
        public double SalarioBase { get; set; }
        public Funcionario (Cargo cargo, double salarioBase) {
            this.SalarioBase = salarioBase;
            this.Cargo = cargo;
        }

        public double CalculaSalario(){
            return this.Cargo.Regra.Calcula(this);
        }
    }
}