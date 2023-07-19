using AutoMapper;
using Shop.Core.Entities;
using Shop.Core.Repositories;
using Shop.Service.Dtos;
using Shop.Service.Dtos.Brand;
using Shop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Implementations
{
    public class BrandService : IBrandService
    {
        private readonly IBrandRepository _brandRepoitory;
        private readonly IMapper _mapper;

        public BrandService(IMapper mapper,IBrandRepository brand)
        {
            _mapper = mapper;
            _brandRepoitory = brand;
        }

        public CreatedResultDto Add(BrandCreateDto dto)
        {
            Brand brand=_mapper.Map<Brand>(dto);
            _brandRepoitory.Add(brand);
            _brandRepoitory.Commit();
            return _mapper.Map<CreatedResultDto>(brand);
        }

        public void Edit(int id, BrandEditDto dto)
        {
            throw new NotImplementedException();
        }

        public List<BrandGetDto> Get()
        {
            throw new NotImplementedException();
        }

        public BrandGetDto Get(int id)
        {
            throw new NotImplementedException();
        }

        public void Remove(int id)
        {
            throw new NotImplementedException();
        }
    }
}
