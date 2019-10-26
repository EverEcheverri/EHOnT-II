using Employees.Repository.Interfaces;
using Employees.Repository.ResourceAccess;
using Employees.Repository.Services;
using Microsoft.Extensions.DependencyInjection;

namespace Employees.Repository.Extensions
{
    public static class ServiceCollectionExtensions
    {
        public static IServiceCollection AddRepositoryLayer(this IServiceCollection services, string apiUrl)
        {   
            services.AddScoped<IEmployeesRepository, EmployeesResource>();
            services.AddScoped<IBaseClient, BaseClient>();
            services.AddScoped<IHttpClientService, HttpClientService>();
            services.AddScoped<IBaseClient>(x => new BaseClient(apiUrl));
            return services;
        }
    }
}
