namespace ERPBackend.WareHouses.Infrastructure.API.Brands;

public static class GetBrandEndpoints
{
    public static WebApplication UseGetBrandEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/brands/get",
                async (IGetBrandInputPort inputPort, IGetBrandOutputPort presenter) =>
                {
                    await inputPort.HandleAsync();

                    return presenter.Response;
                    
                }).Produces<IReadOnlyList<GetBrandResponseDto>>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest).WithTags("Brands");

        return app;
    } 
}