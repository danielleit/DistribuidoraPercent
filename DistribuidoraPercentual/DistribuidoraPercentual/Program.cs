namespace DistribuidoraPercentual {
    class Program {
        static void Main(string[] args) {

            List<DistribuidoraEstado> distribuidoras = new List<DistribuidoraEstado>();

            DistribuidoraEstado sp = new DistribuidoraEstado("SP", 67836.43);
            DistribuidoraEstado rj = new DistribuidoraEstado("rj", 36678.66);
            DistribuidoraEstado mg = new DistribuidoraEstado("mg", 29229.88);
            DistribuidoraEstado es = new DistribuidoraEstado("es", 27165.48);
            DistribuidoraEstado outros = new DistribuidoraEstado("outros", 19849.53);

            distribuidoras.Add(sp);
            distribuidoras.Add(rj);
            distribuidoras.Add(mg);
            distribuidoras.Add(es);
            distribuidoras.Add(outros);

            double valorTotal = 0;
            double percentual = 0;

            foreach(DistribuidoraEstado distribuidora in distribuidoras) {
                valorTotal += distribuidora.FaturamentoMensal;
            }

            foreach (DistribuidoraEstado distribuidora in distribuidoras) {
                distribuidora.Porcentagem = Math.Round((distribuidora.FaturamentoMensal / valorTotal) * 100, 2);
            }

            foreach (DistribuidoraEstado distribuidora in distribuidoras) {
                Console.WriteLine($"O percentual de representacao que '{distribuidora.Estado}' teve dentro do valor total mensal da distribuidora foi de {distribuidora.Porcentagem}%!");
            }

        }
    }
}
