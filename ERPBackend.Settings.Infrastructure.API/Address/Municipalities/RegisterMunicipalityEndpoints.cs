namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Municipalities;

public static class RegisterMunicipalityEndpoints
{
    public static WebApplication UseRegisterMunicipalityEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/municipalities/register",
                async (IRegisterMunicipalityInputPort inputPort, IRegisterMunicipalityOutputPort presenter,
                    [FromBody] RegisterMunicipalityPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.MunicipalityId;
                }).Produces<int>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);

        return app;
    }
}