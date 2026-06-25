using MediatR;
using Products.Application.Features.Products.DTOs;
using Products.Application.Interfaces;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Application.Features.Products.Queries
{
    public class GetProductByIdQueryHandler
    : IRequestHandler<GetProductByIdQuery, ProductDto>
    {
        private readonly IProductRepository _repository;

        public GetProductByIdQueryHandler(
            IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<ProductDto> Handle(
            GetProductByIdQuery request,
            CancellationToken cancellationToken)
        {
            var product =
                await _repository.GetByIdAsync(request.Id);

            if (product == null)
                return null!;

            return new ProductDto
            {
                Id = product.Id,
                Name = product.Name,
                Price = product.Price
            };
        }
    }
}
