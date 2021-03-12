using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor;
using Api.VendaVeiculo.Application.ViewModels;
using Api.VendaVeiculo.Domain.Entities;
using Api.VendaVeiculo.Domain.Repositories;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.Application.Services
{
    public class CadastraVendedorUseCase : ICadastraVendedorUseCase
    {
        private readonly ICadastraVendedorOutputPort _outputPort;
        private readonly ISqlRepository<Vendedor> _repository;

        public CadastraVendedorUseCase(ICadastraVendedorOutputPort outputPort, ISqlRepository<Vendedor> repository)
        {
            _outputPort = outputPort;
            _repository = repository;
        }

        public async Task Execute(CadastraVendedorModel input)
        {
            input.Validate();

            if (input.Valid)
            {
                await _repository.Create(input);
                _outputPort.Success(new CadastraVendedorOutput("Vendedor Cadastrado com Sucesso!"));
                return;
            }

            _outputPort.WriteError(input.Notifications);
        }
    }
}
