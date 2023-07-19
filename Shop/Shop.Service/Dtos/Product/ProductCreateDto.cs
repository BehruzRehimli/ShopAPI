using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Dtos.Product
{
    public class ProductCreateDto
    {
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CostPrice { get; set; }
        public int BrandId { get; set; }
    }
    public class ProductCreateDtoValidation:AbstractValidator<ProductCreateDto>
    {
        public ProductCreateDtoValidation()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100).MinimumLength(3);
            RuleFor(x => x.SalePrice).GreaterThan(0);
            RuleFor(x => x.CostPrice).GreaterThan(0);
            RuleFor(x=>x.BrandId).GreaterThan(0);
        }
    }

}
