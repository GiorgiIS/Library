using Microsoft.Extensions.DependencyInjection;
using Library.Application;
using Library.Interfaces.Services;
using Library.Repository.Implementations;
using Library.Repository.Interfaces;

namespace Library.Common.Api
{
    public static class ConfigureServicesHelper
    {
        public static IServiceCollection RegisterServicesAndRepositorys(this IServiceCollection services)
        {
			return services;
        }
    }
}
