﻿using FluentValidation;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Shop.Service.Dtos.Brand
{
    public class BrandEditDto
    {
        public string Name { get; set; }
    }
    public class BrandEditDtoValidation : AbstractValidator<BrandEditDto>
    {
        public BrandEditDtoValidation()
        {
            RuleFor(x => x.Name).NotEmpty().MaximumLength(100).MinimumLength(3);
        }
    }
}
