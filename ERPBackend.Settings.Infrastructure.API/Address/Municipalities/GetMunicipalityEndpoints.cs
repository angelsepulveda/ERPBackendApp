namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Municipalities;

public static class GetMunicipalityEndpoints
{
    public static WebApplication UseGetMunicipalityEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/municipalities/get",
                async (IGetMunicipalityInputPort inputPort, IGetMunicipalityOutputPort presenter) =>
                {
                    await inputPort.HandleAsync();

                    return presenter.Response;
                    
                }).Produces<IReadOnlyList<GetMunicipalityResponseDto>>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);

        return app;
    } 
}