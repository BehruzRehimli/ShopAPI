using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Dtos.Brand
{
    public class BrandGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductsCount { get; set; }
    }
}
