﻿using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Estacionamento.Entidades
{
    internal class Veiculo
    {
        public string Modelo { get; set; }

        public Veiculo (string modelo)
        {
            Modelo = modelo;
        }
    }
}
