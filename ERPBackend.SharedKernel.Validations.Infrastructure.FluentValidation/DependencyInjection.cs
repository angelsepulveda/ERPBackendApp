namespace ERPBackend.SharedKernel.Validations.Infrastructure.FluentValidation;

public static class DependencyInjection
{
    public static IServiceCollection AddFluentValidationServices(this IServiceCollection services)
    {
        services.AddScoped(typeof(IValidationService<>), typeof(FluentValidationService<>));
        
        return services;
    }
}