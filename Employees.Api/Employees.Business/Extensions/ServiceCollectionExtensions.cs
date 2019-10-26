using Employees.Business.Interfaces;
using Employees.Business.Services;
using Employees.Repository.Extensions;
using Microsoft.Extensions.DependencyInjection;
using System;
using System.Collections.Generic;
using System.Text;

namespace Employees.Business.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddBusinessLayer(this IServiceCollection services, string apiUrl)
        {
            services.AddRepositoryLayer(apiUrl);
            services.AddScoped<IEmployeesService, EmployeesService>();            
            return services;
        }
    }
}
