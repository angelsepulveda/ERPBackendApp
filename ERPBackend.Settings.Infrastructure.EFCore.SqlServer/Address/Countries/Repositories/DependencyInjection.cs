namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Countries.Repositories;

public static class DependencyInjection
{
    public static IServiceCollection AddCountriesRepositories(this IServiceCollection services)
    {
        services.AddScoped<IGetCountryRepository, GetCountryRepository>();
        services.AddScoped<IGetByCodeCountryRepository, GetByCodeCountryRepository>();
        services.AddScoped<IGetByNameCountryRepository, GetByNameCountryRepository>();
        services.AddScoped<IRegisterCountryRepository, RegisterCountryRepository>();
        services.AddScoped<IUpdateCountryRepository, UpdateCountryRepository>();
        services.AddScoped<IGetByIdCountryRepository, GetByIdCountryRepository>();
        services.AddScoped<IPaginationCountryRepository, PaginationCountryRepository>();
        
        return services;
    }
}