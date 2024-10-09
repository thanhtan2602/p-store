using Store.Application.IRepository;
using Store.Application.IService;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.Service
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;

        public ProductService(IProductRepository productRepository)
        {
            _productRepository = productRepository;
        }
        public List<Prouduct> GetAllProuducts()
        {
            var products = _productRepository.GetAllProducts();

            return products;
        }
    }
}
