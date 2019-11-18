using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using Salarix.Core;
using Salarix.Core.Bussines;
using Salarix.Core.Bussines.Services;
using Salarix.Data;

namespace Salarix.Host.Backend.Extensions
{
    public static class ISalarixExtensions
    {
        public static IServiceCollection AddBussines(this IServiceCollection services, IConfiguration config)
        {
            services.AddTransient<ISalaryCalculatorFactory, SalaryCalculatorFactory>();
            services.AddTransient<IEmployeeRepository, EmployeeRepository>();
            services.AddTransient<IEmployeeService, EmployeeService>();
            
            return services;
        }
    }
}
