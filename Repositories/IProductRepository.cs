using Entities;
using System.Collections.Generic;

namespace Repositories
{
    public interface IProductRepository
    {
        IEnumerable<ProductModel> GetAll();
    }
}