using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Configuration;

namespace TarikBooks.Application;

public static class ApplicationServicesRegistration
{
    public static IServiceCollection AddApplicationServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddMediatR(cfg => {
            cfg.LicenseKey = configuration["LicenseKeys:MediatRLicenseKey"];
            cfg.RegisterServicesFromAssembly(typeof(ApplicationServicesRegistration).Assembly);
        });

        return services;
    }
}
