using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVenda;
using Api.VendaVeiculo.Application.ViewModels;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.Application.Services.Cadastro_de_Venda
{
    public class CadastraVendaUseCase : ICadastraVendaUseCase
    {
        private readonly ICadastraVendaOutputPort _outPutport;

        public CadastraVendaUseCase(ICadastraVendaOutputPort outPutport)
        {
            _outPutport = outPutport;
        }

        public async Task Execute(CadastraVendaModel input)
        {
            input.Validate();

            if (input.Valid)
            {
                _outPutport.Success(new CadastraVendaOutput("Venda Cadastrada com Sucesso!"));
                return;
            }

            _outPutport.WriteError("error");
            return;
        }
    }
}
