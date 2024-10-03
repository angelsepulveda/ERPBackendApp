namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.Address.Municipalities.Repositories;

public static class DependencyInjection
{
    public static IServiceCollection AddMunicipalitiesRepositories(this IServiceCollection services)
    {
        services.AddScoped<IPaginationMunicipalityRepository, PaginationMunicipalityRepository>();
        services.AddScoped<IRegisterMunicipalityRepository, RegisterMunicipalityRepository>();
        services.AddScoped<IUpdateMunicipalityRepository, UpdateMunicipalityRepository>();
        services.AddScoped<IGetMunicipalityRepository, GetMunicipalityRepository>();
        services.AddScoped<IGetByIdMunicipalityRepository, GetByIdMunicipalityRepository>();
        services.AddScoped<IGetByNameMunicipalityRepository, GetByNameMunicipalityRepository>();
        services.AddScoped<IGetByCodeMunicipalityRepository, GetByCodeMunicipalityRepository>();

        return services;
    }
}