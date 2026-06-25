using Products.Domain.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace Products.Application.Interfaces
{
    public interface IProductRepository
    {
        Task<Product?> GetByIdAsync(Guid id);

        Task<List<Product>> GetAllAsync();

        Task AddAsync(Product product);

        Task SaveChangesAsync();
    }
}
