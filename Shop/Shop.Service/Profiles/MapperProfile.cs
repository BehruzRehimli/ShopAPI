using AutoMapper;
using Shop.Core.Entities;
using Shop.Service.Dtos;
using Shop.Service.Dtos.Brand;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Profiles
{
    public class MapperProfile:Profile
    {
        public MapperProfile()
        {
            CreateMap<Brand, BrandGetDto>();
            CreateMap<BrandCreateDto, Brand>();
            CreateMap<BrandEditDto, Brand>();
            CreateMap<Brand, CreatedResultDto>();
        }
    }
}
