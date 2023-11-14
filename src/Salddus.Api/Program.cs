using FluentValidation;
using System.Reflection;
using Salddus.Api.Features;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen(options =>
{
    var assemblyName = Assembly.GetExecutingAssembly().FullName?.Split(',')[0];
    options.IncludeXmlComments(Path.Combine(AppContext.BaseDirectory, $"{assemblyName}.xml"));
});
builder.Services.AddResponseCompression(options => options.EnableForHttps = true);
builder.Services.AddScoped<IProductByIdQueryHandler, ProductByIdQueryHandler>();
builder.Services.AddScoped<IValidator<ProductByIdQuery>, ProductByIdQueryValidator>();

var app = builder.Build();
app.UseResponseCompression();
app.UseSwagger();
app.UseSwaggerUI();
app.UseHttpsRedirection();
app.RegisterEndpoints();

app.Run();

public partial class Program { }