using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Infrastructure.Repository
{
    public class ProductRepository : IProductRepository
    {
        private static List<Product> products = new List<Product>()
        {
            new Product() { Name="M1", Id=1 },
            new Product() { Name="M2", Id=2 },
            new Product() { Name="M3", Id=3 },
        };

        public List<Product> GetAllProducts()
        {
            return products;
        }
    }
}
