using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.IO;

namespace Api.VendaVeiculo.WebApi.Modules
{
    public static class SwaggerExtensions
    {
        public static void UsaSwaggerUi(this IApplicationBuilder app)
        {
            app.UseSwagger();

            app.UseSwaggerUI(c =>
            {
                c.SwaggerEndpoint("/swagger/v1/swagger.json", "API de venda de veículos");

            });
        }

        public static void ConfiguraSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", new OpenApiInfo
                {
                    Title = "Victor Auto Car - API",
                    Description = "Api responsavel pelo controle de venda de veículos",
                    Version = "v1",
                    TermsOfService = new Uri("https://www.google.com")
                });


                var apiPath = Path.Combine(AppContext.BaseDirectory, "Api.VendaVeiculo.WebApi.xml");
                var applicationPath = Path.Combine(AppContext.BaseDirectory, "Api.VendaVeiculo.Application.xml");

                c.IncludeXmlComments(apiPath);
                c.IncludeXmlComments(applicationPath);
            });
        }
    }
}
