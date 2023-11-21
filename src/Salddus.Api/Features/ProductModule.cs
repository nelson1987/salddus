using FluentValidation;
using Microsoft.AspNetCore.Mvc;
namespace Salddus.Api.Features;
public static class ProductModule
{
    public static void RegisterEndpoints(this IEndpointRouteBuilder app)
    {
        app.MapGroup("/api/v1")
            .MapTodosApi()
            .WithDescription("Descrição")
            .WithTags("Product")
            .WithOpenApi();
    }
    public static RouteGroupBuilder MapTodosApi(this RouteGroupBuilder group)
    {
        group.MapGet("/", GetResultAsync)
                            .Produces<string>()
                            .AddEndpointFilter<ProductFilter>()
                            .WithName("GetWeatherForecast")
                            .WithDescription("Descrição");

        return group;
    }
    /// <summary>
    /// Buscar Resultado
    /// </summary>
    /// <param name="query"></param>
    /// <param name="validator"></param>
    /// <param name="handler"></param>
    /// <returns></returns>
    public static async Task<IResult> GetResultAsync([AsParameters] ProductByIdQuery query,
    [FromServices] IValidator<ProductByIdQuery> validator,
    [FromServices] IProductByIdQueryHandler handler)
    {
        var result = await validator.ValidateAsync(query);
        if (!result.IsValid)
        {

            foreach (var failure in result.Errors)
            {
                Console.WriteLine("Property " + failure.PropertyName + " failed validation. Error was: " + failure.ErrorMessage);
            }
            return Results.BadRequest(result.Errors);
        }

        var response = await handler.Handle(query, CancellationToken.None);
        return Results.Ok(response);
    }
}