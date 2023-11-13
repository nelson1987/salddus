namespace Salddus.Api.Features;
public class ProductModule : IModule
{
    public void RegisterEndpoints(this IEndpointRouteBuilder route)
    {
        app.MapGet("/", () => "Hello World!");
    }
}
public interface IModule
{
    void RegisterEndpoints(IEndpointRouteBuilder app);
}