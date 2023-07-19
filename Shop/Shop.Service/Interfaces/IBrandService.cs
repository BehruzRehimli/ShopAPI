using Shop.Service.Dtos;
using Shop.Service.Dtos.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Interfaces
{
    public interface IBrandService
    {
        CreatedResultDto Add(BrandCreateDto dto);
        void Edit(int id,BrandEditDto dto);
        void Remove(int id);
        List<BrandGetDto> Get();
        BrandGetDto Get(int id);
    }
}
