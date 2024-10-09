using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Application.IService
{
    public interface IProductService
    {
        List<Product> GetAllProducts();
    }
}
