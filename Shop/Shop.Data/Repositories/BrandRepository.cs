using Shop.Core.Entities;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public class BrandRepository : Repositories<Brand>, IBrandRepository
    {
        public BrandRepository(ShopDBContext context) : base(context)
        {
        }
    }
}
