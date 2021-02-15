using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor;
using Api.VendaVeiculo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.Application.Services
{
    public class CadastraVendedorUseCase : ICadastraVendedorUseCase
    {
        private readonly ICadastraVendedorOutputPort _outputPort;

        public CadastraVendedorUseCase(ICadastraVendedorOutputPort outputPort)
        {
            _outputPort = outputPort;
        }

        public async Task Execute(CadastraVendedorModel input)
        {
            input.Validate();

            if (input.Valid)
            {

            }
        }
    }
}
