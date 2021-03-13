using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor;
using Api.VendaVeiculo.Application.ViewModels;
using Api.VendaVeiculo.Domain.Entities;
using Api.VendaVeiculo.Domain.Repositories;
using AutoMapper;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.Application.Services
{
    public class CadastraVendedorUseCase : ICadastraVendedorUseCase
    {
        private readonly ICadastraVendedorOutputPort _outputPort;
        private readonly ISqlRepository<Vendedor> _repository;
        private readonly IMapper _mapper;

        public CadastraVendedorUseCase(ICadastraVendedorOutputPort outputPort, ISqlRepository<Vendedor> repository, IMapper mapper)
        {
            _outputPort = outputPort;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Execute(CadastraVendedorModel input)
        {
            input.Validate();

            if (input.Valid)
            {
                var vendedor = _mapper.Map<Vendedor>(input);
                _repository.Create(vendedor);

                _outputPort.Success(new CadastraVendedorOutput("Vendedor Cadastrado com Sucesso!"));
                return;
            }

            _outputPort.WriteError(input.Notifications);
            return;
        }
    }
}
