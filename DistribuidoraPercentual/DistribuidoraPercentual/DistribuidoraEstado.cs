namespace DistribuidoraPercentual {
    internal class DistribuidoraEstado {
        public string Estado {  get; set; }
        public double FaturamentoMensal { get; set; }

        public double Porcentagem { get; set; } 

        public DistribuidoraEstado(string Estado, double FaturamentoMensal) {
            this.Estado = Estado;
            this.FaturamentoMensal = FaturamentoMensal;
        }
    }
}
