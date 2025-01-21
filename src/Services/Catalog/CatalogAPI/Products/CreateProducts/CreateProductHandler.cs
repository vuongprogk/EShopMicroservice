using MediatR;

namespace CatalogAPI.Products.CreateProducts
{
    public record CreateProductCommand( string Name, List<string> Category, string Description, string ImageUrl, decimal Price) : IRequest<CreateProductResult>;
    public record CreateProductResult(Guid Id);
    internal class CreateProductHandler : IRequestHandler<CreateProductCommand,CreateProductResult>
    {
      

        public Task<CreateProductResult> Handle(CreateProductCommand request, CancellationToken cancellationToken)
        {
            throw new NotImplementedException();
        }
    }
}
