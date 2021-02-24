using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVeiculo;
using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVenda;
using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor;
using Api.VendaVeiculo.WebApi.Presenters;
using Microsoft.Extensions.DependencyInjection;

namespace Api.VendaVeiculo.WebApi.Modules
{
    public static class PresenterExtensions
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<CadastraVendedorPresenter, CadastraVendedorPresenter>();
            services.AddScoped<ICadastraVendedorOutputPort>(x => x.GetRequiredService<CadastraVendedorPresenter>());

            services.AddScoped<CadastraVeiculoPresenter, CadastraVeiculoPresenter>();
            services.AddScoped<ICadastraVeiculoOutputPort>(x => x.GetRequiredService<CadastraVeiculoPresenter>());

            services.AddScoped<CadastraVendaPresenter, CadastraVendaPresenter>();
            services.AddScoped<ICadastraVendaOutputPort>(x => x.GetRequiredService<CadastraVendaPresenter>());
            return services;
        }
    }
}
