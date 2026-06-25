using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Products.Application.Interfaces;
using Products.Infrastructure.Persistence;
using Products.Infrastructure.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Infrastructure
{
    public static class DependencyInjection
    {
        public static IServiceCollection
            AddInfrastructure(
            this IServiceCollection services,
            IConfiguration configuration)
        {
            services.AddDbContext<AppDbContext>(options =>
            {
                options.UseNpgsql(
                    configuration.GetConnectionString(
                        "Postgres"));
            });

            services.AddScoped<
                IProductRepository,
                ProductRepository>();

            return services;
        }
    }
}
