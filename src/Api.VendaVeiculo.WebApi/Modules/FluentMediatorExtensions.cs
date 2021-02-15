﻿using Api.VendaVeiculo.Application.Interfaces.Boundaries.CadastraVendedor;
using Api.VendaVeiculo.Application.ViewModels;
using FluentMediator;
using Microsoft.Extensions.DependencyInjection;

namespace Api.VendaVeiculo.WebApi.Modules
{
    public static class FluentMediatorExtensions
    {
        public static IServiceCollection AddMediator(this IServiceCollection services)
        {
            services.AddFluentMediator(builder =>
            {
                builder.On<CadastraVendedorModel>().PipelineAsync().Call<ICadastraVendedorUseCase>((handler, request) => handler.Execute(request));
            });

            return services;
        }
    }
}
