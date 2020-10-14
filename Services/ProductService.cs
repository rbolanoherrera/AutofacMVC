using Entities;
using Repositories;
using System.Collections.Generic;

namespace Services
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository repository;

        public ProductService(IProductRepository repo)
        {
            repository = repo;
        }

        public IEnumerable<ProductModel> GetProducts()
        {
            return repository.GetAll();
        }
    }
}