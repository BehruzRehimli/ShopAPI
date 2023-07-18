using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Core.Repositories;
using Shop.Service.Dtos.Brand;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class BrandsController : ControllerBase
    {
        private readonly IBrandRepository _brandRepository;

        public BrandsController(IBrandRepository brandRepository)
        {
            _brandRepository = brandRepository;
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
