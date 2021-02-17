using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVeiculo;
using Api.VendaVeiculo.Application.ViewModels;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.Application.Services
{
    public class CadastraVeiculoUseCase : ICadastraVeiculoUseCase
    {
        private readonly ICadastraVeiculoOutputPort _outPutPort;

        public CadastraVeiculoUseCase(ICadastraVeiculoOutputPort outPutPort)
        {
            _outPutPort = outPutPort;
        }

        public async Task Execute(CadastraVeiculoModel input)
        {
            input.Validate();

            if (input.Valid)
            {
                //Manipulação com o bannco de dados aqui.
                _outPutPort.Success(new CadastraVeiculoOutput("Veiculo Cadastrado com sucesso!"));
                return;
            }

            _outPutPort.WriteError(input.Notifications);
            return;
        }
    }
}
