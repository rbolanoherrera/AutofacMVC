using EjemploAutofac.Interfaces;
using EjemploAutofac.Models;
using System.Collections.Generic;
using System.Linq;

namespace EjemploAutofac.Repositories
{
    public class ProductRepository : IProductRepository
    {
        public IEnumerable<ProductModel> GetAll()
        {
            return Enumerable.Range(1, 10).Select(p => new ProductModel() { Id = p, Name = $"Producto Name{p}" });
        }
    }
}