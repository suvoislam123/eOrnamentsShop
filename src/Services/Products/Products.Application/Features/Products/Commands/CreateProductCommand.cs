using MediatR;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Application.Features.Products.Commands
{
    public record CreateProductCommand(
    string Name,
    string Description,
    decimal Price,
    int Stock)
    : IRequest<Guid>;
}
