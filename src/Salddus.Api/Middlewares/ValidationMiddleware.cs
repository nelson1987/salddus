
public class ValidationMiddleware : IMiddleware
{
    private readonly ILogger<ValidationMiddleware> _logger;

    public ValidationMiddleware(ILogger<ValidationMiddleware> logger)
    {
        _logger = logger;
    }

    public async Task InvokeAsync(HttpContext context, RequestDelegate next)
    {
        _logger.LogInformation("ValidationMiddleware Before Request");
        await next.Invoke(context);
        _logger.LogInformation("ValidationMiddleware After Request");
    }
}