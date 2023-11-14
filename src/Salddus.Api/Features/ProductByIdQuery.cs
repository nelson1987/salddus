using Swashbuckle;
using Swashbuckle.AspNetCore.Swagger;
using Swashbuckle.AspNetCore.SwaggerGen;
namespace Salddus.Api.Features;

/// <summary>
/// The id of the fruit that will be created
/// </summary>
/// <param name="Id" example="11"></param>
public record ProductByIdQuery(int Id);
