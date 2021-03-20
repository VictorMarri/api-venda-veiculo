using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVeiculo;
using Api.VendaVeiculo.Application.ViewModels;
using Api.VendaVeiculo.Domain.Entities;
using Api.VendaVeiculo.Domain.Repositories;
using AutoMapper;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.Application.Services
{
    public class CadastraVeiculoUseCase : ICadastraVeiculoUseCase
    {
        private readonly ICadastraVeiculoOutputPort _outPutPort;
        private readonly ISqlRepository<Veiculo> _repository;
        private readonly IMapper _mapper;

        public CadastraVeiculoUseCase(ICadastraVeiculoOutputPort outPutPort, ISqlRepository<Veiculo> repository, IMapper mapper)
        {
            _outPutPort = outPutPort;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Execute(CadastraVeiculoModel input)
        {
            input.Validate();

            if (input.Valid)
            {
                var veiculoInput = _mapper.Map<Veiculo>(input);
                _repository.Create(veiculoInput);
                _outPutPort.Success(new CadastraVeiculoOutput("Veiculo Cadastrado com sucesso!"));
                return;
            }

            _outPutPort.WriteError(input.Notifications);
            return;
        }
    }
}
