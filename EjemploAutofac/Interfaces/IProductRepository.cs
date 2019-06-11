using EjemploAutofac.Models;
using System.Collections.Generic;

namespace EjemploAutofac.Interfaces
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetAll();
        
    }
}