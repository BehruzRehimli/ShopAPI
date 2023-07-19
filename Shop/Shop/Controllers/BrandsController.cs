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
        //[HttpGet]
        //[Route("")]   
        //public ActionResult<BrandGetDto> Get()
        //{
        //    var datas = _brandRepository.GetQueryable(x=>true,"Brand").ToList();

        //    return 
        //}
    }
}
