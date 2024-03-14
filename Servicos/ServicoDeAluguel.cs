using System;
using Estacionamento.Entidades;

namespace Estacionamento.Servicos
{
    internal class ServicoDeAluguel
    {
        public double ValorPorHora { get; private set; }
        public double ValorPorDia { get; private set; }
        public TimeSpan Periodo { get; set; }

        private ImpostoBrasil _impostoBrasil = new ImpostoBrasil();
        public ServicoDeAluguel(double valorPorHora, double valorPorDia)
        {
            ValorPorHora = valorPorHora;
            ValorPorDia = valorPorDia;
            
        }

        public void ProcessoDePagamento(AluguelCarro aluguelDeCarro)
        {
            TimeSpan duration = aluguelDeCarro.Final.Subtract(aluguelDeCarro.Inicio);

            double pagamentoBasico = 0.0;

            if(duration.TotalHours <=12)
            {
                pagamentoBasico = ValorPorHora * Math.Ceiling(duration.TotalHours);
            }
            else
            {
                pagamentoBasico = ValorPorDia * Math.Ceiling(duration.TotalDays);   

                
            }

            double imposto = _impostoBrasil.Imposto(pagamentoBasico);

            aluguelDeCarro.Fatura = new Fatura(pagamentoBasico, imposto);
            Periodo = duration;
        }
    }
}
