namespace ERPBackend.WareHouses.Infrastructure.API.Brands;

public static class PaginationBrandEndpoints
{
    public static WebApplication UsePaginationBrandEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/brands/pagination",
                async (IPaginationBrandInputPort inputPort, IPaginationBrandOutputPort presenter,
                    [FromBody] PaginationBrandPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.Response;
                    
                }).Produces<PaginationBrandResponseDto>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest).WithTags("Brands");

        return app;
    }
}