using FluentValidation;
namespace Salddus.Api.Features;
public static class ProductModule
{
    public static void RegisterEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGroup("/api/v1")
            .MapTodosApi()
            .WithDescription("Descrição")
            .WithTags("Tag1");
    }
    public static RouteGroupBuilder MapTodosApi(this RouteGroupBuilder group)
    {
        group.MapGet("/", GetResultAsync)
                            .Produces<string>()
                            .AddEndpointFilter<ProductFilter>();

        return group;
    }
    public static async Task<IResult> GetResultAsync(ProductByIdQuery query, IValidator<ProductByIdQuery> validator, IProductByIdQueryHandler handler)
    {
        var result = await validator.ValidateAsync(query);
        if (!result.IsValid) return Results.BadRequest(result.Errors);

        var response = await handler.Handle(query, CancellationToken.None);
        return Results.Ok(response);
    }
}