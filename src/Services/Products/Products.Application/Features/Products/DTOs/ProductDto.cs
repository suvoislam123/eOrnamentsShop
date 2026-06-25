using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Application.Features.Products.DTOs
{
    public class ProductDto
    {
        public Guid Id { get; set; }

        public string Name { get; set; } = string.Empty;

        public decimal Price { get; set; }
    }
}
