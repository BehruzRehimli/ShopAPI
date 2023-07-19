using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Repositories;
using Shop.Service.Dtos;
using Shop.Service.Dtos.Brand;
using Shop.Service.Interfaces;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandService _brandService;

        public BrandsController(IBrandService brandService)
        {
            _brandService = brandService;
        }
        [HttpPost("")]
        public ActionResult<CreatedResultDto> Add(BrandCreateDto dto)
        {
            return _brandService.Add(dto);
        }
        [HttpPut("{id")]
        public ActionResult Edit(int id,BrandEditDto dto)
        {
            _brandService.Edit(id,dto);
            return NoContent();
        }

    }
}
