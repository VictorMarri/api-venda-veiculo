using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVeiculo;
using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVenda;
using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor;
using Api.VendaVeiculo.Application.Services;
using Api.VendaVeiculo.Application.Services.Cadastro_de_Venda;
using Microsoft.Extensions.DependencyInjection;

namespace Api.VendaVeiculo.WebApi.Modules
{
    public static class UseCaseExtensions
    {
        public static IServiceCollection AddUseCase(this IServiceCollection services)
        {
            services.AddScoped<ICadastraVendedorUseCase, CadastraVendedorUseCase>();

            services.AddScoped<ICadastraVeiculoUseCase, CadastraVeiculoUseCase>();

            services.AddScoped<ICadastraVendaUseCase, CadastraVendaUseCase>();
            return services;
        }
    }
}
