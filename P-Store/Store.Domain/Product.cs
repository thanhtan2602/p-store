using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Store.Domain
{
    public class Product
    {
        public Product()
        {
            
        }

        public Product(int Id, string Name, bool IsActive)
        {
            this.Id = Id;
            this.Name = Name;
            this.IsActive = IsActive;
        }
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public int IsActive { get; set; } = true;
    }
}
