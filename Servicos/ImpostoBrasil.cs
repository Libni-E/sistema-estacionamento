using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Servicos
{
    internal class ImpostoBrasil
    {
        public double Imposto (double quantia)
        {
            if ( quantia <= 100)
            {
                return quantia * 0.2;
            }
            else
            {
                return quantia * 0.15;
            }
        }

    }
}
