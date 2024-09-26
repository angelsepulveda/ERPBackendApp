namespace ERPBackend.Settings.Infrastructure.Presenters.Address.Countries;

public static class DependencyInjection
{
    public static IServiceCollection AddCountriesPresenters(this IServiceCollection services)
    {
        services.AddScoped<IGetCountryOutputPort, GetCountryPresenter>();
        services.AddScoped<IUpdateCountryOutputPort, UpdateCountryPresenter>();
        services.AddScoped<IRegisterCountryOutputPort, RegisterCountryPresenter>();
        services.AddScoped<IPaginationCountryOutputPort, PaginationCountryPresenter>();
        
        return services;
    }
}