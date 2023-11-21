using FluentValidation;
using System.Reflection;
using Salddus.Api.Features;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var xmlFilename = $"{Assembly.GetExecutingAssembly().GetName().Name}.xml";
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, xmlFilename));
});
builder.Services.AddResponseCompression(options => options.EnableForHttps = true);
builder.Services.AddScoped<IProductByIdQueryHandler, ProductByIdQueryHandler>();
builder.Services.AddScoped<IValidator<ProductByIdQuery>, ProductByIdQueryValidator>();

var app = builder.Build();
app.UseResponseCompression();
app.UseSwagger();
app.UseSwaggerUI(options =>
{
    options.SwaggerEndpoint("/swagger/v1/swagger.json", "v1");
    options.RoutePrefix = string.Empty;
});
app.UseHttpsRedirection();
app.RegisterEndpoints();

app.Run();

public partial class Program { }