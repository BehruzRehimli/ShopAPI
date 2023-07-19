using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Dtos.Product
{
    public class ProductGetDto
    {
        public string Name  { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CostPrice { get; set; }

        public ProductGetBrandDto Brand { get; set; }
    }
    public class ProductGetBrandDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
    }
}
