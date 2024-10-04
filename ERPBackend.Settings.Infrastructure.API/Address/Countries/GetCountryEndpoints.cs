namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Countries;

public static class GetCountryEndpoints
{
    public static WebApplication UseGetCountryEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/countries/get",
                async (IGetCountryInputPort inputPort, IGetCountryOutputPort presenter) =>
                {
                    await inputPort.HandleAsync();

                    return presenter.Response;
                    
                }).Produces<IReadOnlyList<GetCountryResponseDto>>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest).WithTags("Countries");

        return app;
    } 
}