using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor;
using Api.VendaVeiculo.Application.Services;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace Api.VendaVeiculo.WebApi.Modules
{
    public static class UseCaseExtensions
    {
        public static IServiceCollection AddUseCase(this IServiceCollection services)
        {
            services.AddScoped<ICadastraVendedorUseCase, CadastraVendedorUseCase>();

            return services;
        }
    }
}
