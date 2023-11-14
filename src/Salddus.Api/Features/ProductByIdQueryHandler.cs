namespace Salddus.Api.Features;

public class ProductByIdQueryHandler : IProductByIdQueryHandler
{
    public async Task<ProductByIdQueryResponse> Handle(ProductByIdQuery request, CancellationToken cancellationToken)
    {
        return new ProductByIdQueryResponse("Hello World!");
    }
};