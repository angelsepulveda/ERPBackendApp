namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Municipalities;

public static class DependencyInjection
{
    public static IServiceCollection AddMunicipalitiesPresenters(this IServiceCollection services)
    {
        services.AddScoped<IGetMunicipalityOutputPort, GetMunicipalityPresenter>();
        services.AddScoped<IPaginationMunicipalityOutputPort, PaginationMunicipalityPresenter>();
        services.AddScoped<IRegisterMunicipalityOutputPort, RegisterMunicipalityPresenter>();
        services.AddScoped<IUpdateMunicipalityOutputPort, UpdateMunicipalityPresenter>();

        return services;
    }
}