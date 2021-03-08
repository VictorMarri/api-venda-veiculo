using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVeiculo;
using Api.VendaVeiculo.Application.ViewModels;
using Api.VendaVeiculo.Domain.Entities;
using Api.VendaVeiculo.Domain.Repositories;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.Application.Services
{
    public class CadastraVeiculoUseCase : ICadastraVeiculoUseCase
    {
        private readonly ICadastraVeiculoOutputPort _outPutPort;
        private readonly ISqlRepository<Veiculo> _repository;

        public CadastraVeiculoUseCase(ICadastraVeiculoOutputPort outPutPort, ISqlRepository<Veiculo> repository)
        {
            _outPutPort = outPutPort;
            _repository = repository;
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
