namespace Salddus.Api.Features;
// public class ValidationFilter<T> : IRouteHandlerFilter where T : class
// {

// }

public class ProductFilter : IEndpointFilter
{
    private readonly ILogger _logger;

    public ProductFilter(ILogger<ProductFilter> logger)
    {
        _logger = logger;
    }

    public async ValueTask<object?> InvokeAsync(EndpointFilterInvocationContext context, EndpointFilterDelegate next)
    {
        var firstname = context.HttpContext.GetRouteData().Values["firstname"];
        _logger.LogInformation($"AddEndpointFilter before filter using parameter firstname: {firstname}");
        var result = await next(context);
        _logger.LogInformation($"AddEndpointFilter after filter using parameter firstname: {firstname}");
        return result;
    }
}