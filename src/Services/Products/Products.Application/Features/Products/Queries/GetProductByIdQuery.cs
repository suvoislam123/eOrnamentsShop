using MediatR;
using Products.Application.Features.Products.DTOs;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Application.Features.Products.Queries
{
    public record GetProductByIdQuery(Guid Id)
    : IRequest<ProductDto>;
}
