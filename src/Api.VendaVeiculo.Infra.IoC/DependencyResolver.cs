using Api.VendaVeiculo.Infra.Data.Context;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Api.VendaVeiculo.Infra.IoC
{
    public static class DependencyResolver
    {
        public static void AddSettingsConfig(this IServiceCollection services, IConfiguration Configuration)
        {
            services.AddDbContext<SqlContext>(options =>
            {
                options.UseSqlServer(Configuration.GetConnectionString("DefaultConnection"));
            });
        }
    }
}
