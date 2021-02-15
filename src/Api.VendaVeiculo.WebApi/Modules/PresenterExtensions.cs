using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor;
using Api.VendaVeiculo.WebApi.Presenters;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.WebApi.Modules
{
    public static class PresenterExtensions
    {
        public static IServiceCollection AddPresenters(this IServiceCollection services)
        {
            services.AddScoped<CadastraVendedorPresenter, CadastraVendedorPresenter>();
            services.AddScoped<ICadastraVendedorOutputPort>(x => x.GetRequiredService<CadastraVendedorPresenter>());

            return services;
        }
    }
}
