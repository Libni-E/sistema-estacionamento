using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Entidades
{
    internal class AluguelCarro
    {
        public DateTime Inicio { get; set; }
        public DateTime Final { get; set; }

        public Veiculo Veiculo { get; set; } 

        public Fatura Fatura { get; set; }

        public AluguelCarro(DateTime inicio, DateTime final, Veiculo veiculo)
        {
            Inicio = inicio;
            Final = final;
            Veiculo = veiculo;
            Fatura = null;
        }


    }
}
