using Microsoft.Extensions.DependencyInjection;
using MoneyMe.Application.Interface;
using MoneyMe.Insfrastracture.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace MoneyMe.Insfrastracture
{
    public static class DependencyInjection
    {
        public static IServiceCollection AddInfrastructure(this IServiceCollection services)
        {
            services.AddTransient<IOrderRepository, OrderRepository>();
            services.AddTransient<IUnitOfWork, UnitOfWork>();
            return services;
        }
    }
}
