namespace ERPBackend.Settings.Infrastructure.Presenters.DocumentTypes;

public static class DependencyInjection
{
    public static IServiceCollection AddDocumentTypePresenters(this IServiceCollection services)
    {
        services.AddScoped<IRegisterDocumentTypeOutputPort, RegisterDocumentTypePresenter>();
        services.AddScoped<IGetAllDocumentTypeOutputPort, GetAllDocumentTypePresenter>();
        services.AddScoped<IPaginationDocumentTypeOutputPort, PaginationDocumentTypePresenter>();

        return services;
    }
}