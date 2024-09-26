namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Countries;

public static class RegisterCountryEndpoints
{
    public static WebApplication UseRegisterCountryEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/countries/register",
                async (IRegisterCountryInputPort inputPort, IRegisterCountryOutputPort presenter,
                    [FromBody] RegisterCountryPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.CountryId;
                }).Produces<int>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);
        
        return app;
    }
}