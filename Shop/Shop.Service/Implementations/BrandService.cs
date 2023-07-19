using AutoMapper;
using Shop.Core.Entities;
using Shop.Core.Repositories;
using Shop.Service.Dtos;
using Shop.Service.Dtos.Brand;
using Shop.Service.Exceptions;
using Shop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
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
            if (_brandRepoitory.IsExist(x=>x.Name==dto.Name))
            {
                throw new RestException(System.Net.HttpStatusCode.BadRequest, "name", "Name already exsist!");
            }
            Brand brand=_mapper.Map<Brand>(dto);
            _brandRepoitory.Add(brand);
            _brandRepoitory.Commit();
            return _mapper.Map<CreatedResultDto>(brand);
        }

        public void Edit(int id, BrandEditDto dto)
        {
            Brand brand = _brandRepoitory.Get(x => x.Id == id, "Products");
            if (brand==null)
            {
                throw new RestException(HttpStatusCode.NotFound, $"Product not found by id {id}");
            }
            if (_brandRepoitory.IsExist(x=>x.Name==dto.Name))
            {
                throw new RestException(HttpStatusCode.BadRequest,"name", $"Name already exsist!");
            }
            brand.Name= dto.Name;
            _brandRepoitory.Commit();
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
