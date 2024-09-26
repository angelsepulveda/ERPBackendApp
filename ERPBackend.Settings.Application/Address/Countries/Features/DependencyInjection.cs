namespace ERPBackend.Settings.Application.Address.Countries.Features;

public static class DependencyInjection
{
    public static IServiceCollection AddCountriesFeatures(this IServiceCollection services)
    {
        services.AddScoped<IRegisterCountryInputPort, RegisterCountryInteractor>();
        services.AddScoped<IUpdateCountryInputPort, UpdateCountryInteractor>();
        services.AddScoped<IDeleteCountryInputPort, DeleteCountryInteractor>();
        services.AddScoped<IPaginationCountryInputPort, PaginationCountryInteractor>();
        services.AddScoped<IGetCountryInputPort, GetCountryInteractor>();
        services.AddScoped<IRestoreCountryInputPort, RestoreCountryInteractor>();
        
        return services;
    }
}