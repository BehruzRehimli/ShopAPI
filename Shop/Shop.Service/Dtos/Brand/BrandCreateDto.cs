using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Dtos.Brand
{
    public class BrandCreateDto
    {
        public string Name { get; set; }
    }
    public class BrandCreateDtoValidator : AbstractValidator<BrandCreateDto> 
    {
        public BrandCreateDtoValidator()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100).MinimumLength(3);
        }
    
    }

}
