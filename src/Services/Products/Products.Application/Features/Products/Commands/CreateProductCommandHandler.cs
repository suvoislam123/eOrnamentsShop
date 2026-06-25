using MediatR;
using Products.Application.Interfaces;
using Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Application.Features.Products.Commands
{
    public class CreateProductCommandHandler
    : IRequestHandler<CreateProductCommand, Guid>
    {
        private readonly IProductRepository _repository;

        public CreateProductCommandHandler(
            IProductRepository repository)
        {
            _repository = repository;
        }

        public async Task<Guid> Handle(
            CreateProductCommand request,
            CancellationToken cancellationToken)
        {
            var product = new Product
            {
                Id = Guid.NewGuid(),
                Name = request.Name,
                Description = request.Description,
                Price = request.Price,
                Stock = request.Stock
            };

            await _repository.AddAsync(product);

            await _repository.SaveChangesAsync();

            return product.Id;
        }
    }
    }
