using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Dtos.Brand
{
    public class BrandGetDto
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public int ProductsCount { get; set; }
    }
    public class BrandGetDtoValidator : AbstractValidator<BrandGetDto>
    {
        public BrandGetDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100).MinimumLength(3);
        }
    }
}
