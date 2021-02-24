using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVenda
{
    public class CadastraVendaOutput 
    {
        public string Result { get; set; }

        public CadastraVendaOutput(string response)
        {
            Result = response;
        }
    }
}
