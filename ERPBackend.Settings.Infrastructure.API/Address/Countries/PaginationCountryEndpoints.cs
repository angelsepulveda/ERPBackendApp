namespace ERPBackend.Settings.Infrastructure.APÍ.Address.Countries;

public static class PaginationCountryEndpoints
{
    public static WebApplication UsePaginationCountryEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/countries/pagination",
                async (IPaginationCountryInputPort inputPort, IPaginationCountryOutputPort presenter,
                    [FromBody] PaginationCountryPaylaodDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.Response;
                    
                }).Produces<PaginationCountryResponseDto>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest).WithTags("Countries");

        return app;
    }
}