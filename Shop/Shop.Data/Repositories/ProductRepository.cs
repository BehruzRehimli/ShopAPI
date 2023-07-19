using Shop.Core.Entities;
using Shop.Core.Repositories;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Data.Repositories
{
    public class ProductRepository : Repositories<Product>, IProductRepository
    {
        public ProductRepository(ShopDBContext context):base(context)
        {

        }
    }
}
