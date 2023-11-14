using FluentValidation;
namespace Salddus.Api.Features;

public class ProductByIdQueryValidator : AbstractValidator<ProductByIdQuery>
{
    public ProductByIdQueryValidator()
    {
    }
}
