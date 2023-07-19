using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Dtos.Product
{
    public class ProductEditDto
    {
        public string Name { get; set; }
        public decimal SalePrice { get; set; }
        public decimal CostPrice { get; set; }
        public int BrandId { get; set; }

    }
    public class ProductEditDtoValidator : AbstractValidator<ProductEditDto>
    {
        public ProductEditDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100).MinimumLength(3);
            RuleFor(x=>x.SalePrice).GreaterThanOrEqualTo(1);
            RuleFor(x => x.CostPrice).GreaterThanOrEqualTo(1);
            RuleFor(x => x.BrandId).GreaterThanOrEqualTo(1);
        }
    }
}
