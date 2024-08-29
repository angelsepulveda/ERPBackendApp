namespace ERPBackend.Settings.Infrastructure.Presenters.VoucherTypes;

public static class DependencyInjection
{
    public static IServiceCollection AddVoucherTypePresenters(this IServiceCollection services)
    {
        services.AddScoped<IRegisterVoucherTypeOutputPort, RegisterVoucherTypePresenter>();
        services.AddScoped<IPaginationVoucherTypeOutputPort, PaginationVoucherTypePresenter>();
        services.AddScoped<IUpdateVoucherTypeOutputPort, UpdateVoucherTypePresenter>();

        return services;
    }
}