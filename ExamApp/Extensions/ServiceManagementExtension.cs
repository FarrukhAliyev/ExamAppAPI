using ExamApp.Abstraction;
using ExamApp.Concrete;

namespace ExamApp.Extensions;

public static class ServiceManagementExtension
{
    public static void AddServiceManagementExtension(this IServiceCollection services)
    {
        services.AddScoped<IDersRepository, DersRepository>();
        services.AddScoped<IImtahanRepository, ImtahanRepository>();
        services.AddScoped<IShagirdRepository, ShagirdRepository>();
    }
}
