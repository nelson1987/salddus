namespace Salddus.Api.Features;

public static class ProductByIdQueryResponseMapper
{
  public static ProductByIdQueryResponse ToResponse(this ProductByIdQuery request)   
  {
    return new ProductByIdQueryResponse("Mensagem");
  }
}