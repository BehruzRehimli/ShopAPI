using AutoMapper;
using Shop.Core.Entities;
using Shop.Core.Repositories;
using Shop.Service.Dtos;
using Shop.Service.Dtos.Product;
using Shop.Service.Exceptions;
using Shop.Service.Interfaces;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Net;
using System.Security.Cryptography.X509Certificates;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Implementations
{
    public class ProductService : IProductService
    {
        private readonly IProductRepository _productRepository;
        private readonly IMapper _mapper;
        private readonly IBrandRepository _brandRepository;

        public ProductService(IProductRepository productRepository, IMapper mapper, IBrandRepository brandRepository)
        {
            _productRepository = productRepository;
            _mapper = mapper;
            _brandRepository = brandRepository;
        }

        public CreatedResultDto Add(ProductCreateDto dto)
        {
            if (!_brandRepository.IsExist(x=>x.Id==dto.BrandId))
            {
                throw new RestException(HttpStatusCode.BadRequest, "BrandId", $"There is no Brand in {dto.BrandId} id");
            }
            Product product=_mapper.Map<Product>(dto);
            _productRepository.Add(product);
            _productRepository.Commit();
            return _mapper.Map<CreatedResultDto>(product);
        }

        public void Edit(int id, ProductEditDto dto)
        {
            if (!_productRepository.IsExist(x=>x.Id==id))
            {
                throw new RestException(HttpStatusCode.NotFound, $"Product not found by id {id}");
            }
            if (!_brandRepository.IsExist(x=>x.Id==dto.BrandId))
            {
                throw new RestException(HttpStatusCode.BadRequest, "BrandId", $"There is no Brand in {dto.BrandId} id");
            }
            Product product = _productRepository.Get(x => x.Id == id);
            product.Name = dto.Name;
            product.SalePrice= dto.SalePrice;
            product.CostPrice= dto.CostPrice;
            product.BrandId= dto.BrandId;
            product.LastModifiedAt= DateTime.UtcNow;
            _productRepository.Commit();
        }

        public List<ProductGetAllDto> Get()
        {
            List<Product> datas =_productRepository.GetQueryable(x => true, "Brand").ToList();
            return _mapper.Map<List<ProductGetAllDto>>(datas);
        }

        public ProductGetDto Get(int id)
        {
            Product product = _productRepository.Get(x => x.Id == id,"Brand");
            if (product==null)
            {
                throw new RestException(HttpStatusCode.NotFound, $"Product not found by id {id}");
            }
            return _mapper.Map<ProductGetDto>(product);
        }

        public void Remove(int id)
        {
            Product product = _productRepository.Get(x => x.Id == id,"Brand");
            if (product == null)
            {
                throw new RestException(HttpStatusCode.NotFound, $"Product not found by id {id}");
            }
            _productRepository.Remove(product);
            _productRepository.Commit();
        }
    }
}
