namespace ERPBackend.WareHouses.Infrastructure.API.Brands;

public static class UpdateBrandEndpoints
{
    public static WebApplication UseUpdateBrandEndpoint(this WebApplication app)
    {
        app.MapPut("api/v1/brands/update",
                async (IUpdateBrandInputPort inputPort, IUpdateBrandOutputPort presenter,
                    [FromBody] UpdateBrandPayloadDto dto) =>
                {
                    await inputPort.HandleAsync(dto);

                    var result = presenter.Response;

                    return TypedResults.Ok(result);
                    
                }).Produces<UpdateBrandResponseDto>(StatusCodes.Status200OK)
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest)
            .Produces<ProblemDetails>(StatusCodes.Status404NotFound);
        return app;
    }
}