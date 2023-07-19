using Shop.Core.Entities;
using Shop.Service.Dtos;
using Shop.Service.Dtos.Product;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Interfaces
{
    public interface IProductService
    {
        CreatedResultDto Add(ProductCreateDto dto);
        void Edit(int id, ProductEditDto dto);
        void Remove(int id);
        List<ProductGetAllDto> Get();
        ProductGetDto Get(int id);


    }
}
