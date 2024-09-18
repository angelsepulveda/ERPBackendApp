namespace ERPBackend.WareHouses.Infrastructure.API.Categories;

public static class RegisterCategoryEndpoints
{
    public static WebApplication UseRegisterCategoryEndpoint(this WebApplication app)
    {
        app.MapPost("api/v1/categories/register",
                async (IRegisterCategoryInputPort inputPort, IRegisterCategoryOutputPort presenter,
                    [FromBody] RegisterCategoryPayloadDto payload) =>
                {
                    await inputPort.HandleAsync(payload);

                    return presenter.CategoryId;
                }).Produces<int>()
            .Produces<ProblemDetails>(StatusCodes.Status400BadRequest);

        return app;
    }
}