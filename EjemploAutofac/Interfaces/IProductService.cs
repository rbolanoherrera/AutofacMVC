using EjemploAutofac.Models;
using System.Collections.Generic;

namespace EjemploAutofac.Interfaces
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetProducts();
    }
}