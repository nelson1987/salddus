using FluentValidation;
using Salddus.Api.Features;

var builder = WebApplication.CreateBuilder(args);
builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddScoped<IProductByIdQueryHandler, ProductByIdQueryHandler>();
builder.Services.AddScoped<IValidator<ProductByIdQuery>, ProductByIdQueryValidator>();

var app = builder.Build();
app.UseSwagger();
app.UseSwaggerUI();

app.RegisterEndpoints();

app.Run();
