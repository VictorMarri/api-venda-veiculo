using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor
{
    public class CadastraVendedorOutput
    {
        public string result { get; set; }
        public CadastraVendedorOutput(string response)
        {
            result = response;
        }
    }
}
