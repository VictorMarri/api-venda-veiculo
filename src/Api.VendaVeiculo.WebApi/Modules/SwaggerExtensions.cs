using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.OpenApi.Models;
using System;
using System.Collections.Generic;
using System.IO;
using System.Linq;
using System.Threading.Tasks;

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

                c.OAuthClientId(Environment.GetEnvironmentVariable("OAuthClientId"));
            });
        }

        public static void ConfiguraSwagger(this IServiceCollection services)
        {
            services.AddSwaggerGen(c =>
            {
                c.SwaggerDoc("v1", info: new OpenApiInfo
                {
                    Title = "API de Evento Vers",
                    Description = "Api responsavel por Controlar as vendas de veículos",
                    Version = "v1",
                    TermsOfService = new Uri("https://www.google.com")
                });

                c.AddSecurityDefinition("Bearer", new OpenApiSecurityScheme
                {
                    In = ParameterLocation.Header,
                    Description = "Preencha o JWT no campo abaixo para validar a API.",
                    Name = "Authorization",
                    Type = SecuritySchemeType.ApiKey
                });
                c.AddSecurityRequirement(new OpenApiSecurityRequirement {
                {
                     new OpenApiSecurityScheme
                     {
                        Reference = new OpenApiReference
                        {
                          Type = ReferenceType.SecurityScheme,
                          Id = "Bearer"
                        }
                     }, new string[] { }
                    }
                });

                var apiPath = Path.Combine(AppContext.BaseDirectory, "Api.VendaVeiculo.WebApi.xml");
                var applicationPath = Path.Combine(AppContext.BaseDirectory, "Api.VendaVeiculo.Application.xml");

                c.IncludeXmlComments(apiPath);
                c.IncludeXmlComments(applicationPath);
            });
        }
    }
}
