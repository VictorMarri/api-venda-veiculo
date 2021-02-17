using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVeiculo
{
    public class CadastraVeiculoOutput
    {
        public string result { get; set; }

        public CadastraVeiculoOutput(string response)
        {
            result = response;
        }
    }
}
