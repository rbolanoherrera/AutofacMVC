using EjemploAutofac.Interfaces;
using EjemploAutofac.Models;
using System.Collections.Generic;

namespace EjemploAutofac.Services
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