namespace Salddus.Api.Features;

public interface IProductByIdQueryHandler
{
    Task<ProductByIdQueryResponse> Handle(ProductByIdQuery request, CancellationToken cancellationToken);
}
