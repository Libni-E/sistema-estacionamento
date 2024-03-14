
using System.Globalization;


namespace Estacionamento.Entidades
{
    internal class Fatura
    {
      

        public double PagamentoBasico { get; set; }
        public double Taxa { get; set; }

        public AluguelCarro aluguelCarro1 { get; set; }

        public Fatura(double pagamentoBasico, double taxa)
        {
            PagamentoBasico = pagamentoBasico;
            Taxa = taxa;
        }

        public double PagamentoTotal()
        {
            return PagamentoBasico + Taxa;
        }

        public override string ToString()
        {
            return "Pagamento basico: "
                + PagamentoBasico.ToString("F2", CultureInfo.InvariantCulture)
                + "\nTaxa: "
                + Taxa.ToString("F2", CultureInfo.InvariantCulture)
                +"\nPagamento total: "
                + PagamentoTotal().ToString("F2", CultureInfo.InvariantCulture);
        }

    }
}
