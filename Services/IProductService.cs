using Entities;
using System.Collections.Generic;

namespace Services
{
    public interface IProductService
    {
        IEnumerable<ProductModel> GetProducts();
    }
}