using AutoMapper;
using Shop.Core.Entities;
using Shop.Service.Dtos;
using Shop.Service.Dtos.Brand;
using Shop.Service.Dtos.Product;
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
            CreateMap<Brand, ProductGetAllBrandDto>();
            CreateMap<Brand, ProductGetBrandDto>();
            CreateMap<ProductCreateDto, Product>();
            CreateMap<ProductEditDto, Product>();
            CreateMap<Product, CreatedResultDto>();
            CreateMap<Product, ProductGetAllDto>();
            CreateMap<Product, ProductGetDto>();

        }
    }
}
