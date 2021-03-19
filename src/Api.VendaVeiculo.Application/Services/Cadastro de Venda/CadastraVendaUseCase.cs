using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVenda;
using Api.VendaVeiculo.Application.ViewModels;
using Api.VendaVeiculo.Domain.Entities;
using Api.VendaVeiculo.Domain.Repositories;
using AutoMapper;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.Application.Services.Cadastro_de_Venda
{
    public class CadastraVendaUseCase : ICadastraVendaUseCase
    {
        private readonly ICadastraVendaOutputPort _outPutport;
        private readonly ISqlRepository<Venda> _repository;
        private readonly IMapper _mapper;

        public CadastraVendaUseCase(ICadastraVendaOutputPort outPutport, ISqlRepository<Venda> repository, IMapper mapper)
        {
            _outPutport = outPutport;
            _repository = repository;
            _mapper = mapper;
        }

        public async Task Execute(CadastraVendaModel input)
        {
            input.Validate();

            if (input.Valid)
            {
                var venda = _mapper.Map<Venda>(input);
                _repository.Create(venda);
                _outPutport.Success(new CadastraVendaOutput("Venda Cadastrada com Sucesso!"));
                return;
            }

            _outPutport.WriteError("error");
            return;
        }
    }
}
