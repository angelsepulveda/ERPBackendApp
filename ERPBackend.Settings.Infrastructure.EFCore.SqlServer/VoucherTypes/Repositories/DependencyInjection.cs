namespace ERPBackend.Settings.Infrastructure.EFCore.SqlServer.VoucherTypes.Repositories;

public static class DependencyInjection
{
    public static IServiceCollection AddVoucherTypeRepositories(this IServiceCollection services)
    {
        services.AddScoped<IRegisterVoucherTypeRepository, RegisterVoucherTypeRepository>();
        services.AddScoped<IUpdateVoucherTypeRepository, UpdateVoucherTypeRepository>();
        services.AddScoped<IGetByIdVoucherTypeRepository, GetByIdVoucherTypeRepository>();
        services.AddScoped<IPaginationVoucherTypeRepository, PaginationVoucherTypeRepository>();

        return services;
    }
}