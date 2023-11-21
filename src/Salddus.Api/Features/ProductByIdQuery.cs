using Swashbuckle.AspNetCore.Annotations;
namespace Salddus.Api.Features;

/// <summary>
/// The id of the fruit that will be created
/// </summary>
/// <param name="Id" example="11"></param>
/// 
public record ProductByIdQuery(
    [SwaggerParameter(Description = "The import ID of the group to set the rule parts to", Required = true)]
    int Id,
    [SwaggerParameter(Description = "The import ID of the group to set the rule parts to", Required = true)]
    string Nome);
