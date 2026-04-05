using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.Configuration;
using Microsoft.Extensions.DependencyInjection;
using TarikBooks.Application.Contracts.Data;
using TarikBooks.Dal.Repositories;

namespace TarikBooks.Dal;

public static class DalServiceRegistration
{
    public static IServiceCollection AddDalServices(this IServiceCollection services, IConfiguration configuration)
    {
        services.AddDbContext<TarikBooksDbContext>(options =>
            options.UseSqlServer(configuration.GetConnectionString("TarikBooksDb")));

        services.AddScoped<IBookRepository, BookRepository>();
        
        return services;
    }
}
