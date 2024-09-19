namespace ERPBackend.WareHouses.Infrastructure.API.Brands;

public static class RegisterBrandEndpoints
{
    public static WebApplication UseRegisterBrandEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/brands/register",
                async (IRegisterBrandInputPort inputPort, IRegisterBrandOutputPort presenter,
                    [FromBody] RegisterBrandPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.BrandId;
                }).Produces<Guid>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);

        return app;
    }
}