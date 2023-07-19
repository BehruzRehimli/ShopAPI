using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using Shop.Service.Dtos;
using Shop.Service.Dtos.Product;
using Shop.Service.Interfaces;

namespace Shop.API.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class ProductsController : ControllerBase
    {
        private readonly IProductService _productService;

        public ProductsController(IProductService productService)
        {
            _productService = productService;
        }
        [HttpGet("")]
        public ActionResult<List<ProductGetAllDto>> Get()
        {
            return Ok(_productService.Get());
        }
        [HttpGet("{id}")]
        public ActionResult<ProductGetDto> Get(int id)
        {
            return Ok(_productService.Get(id));
        }
        [HttpPost("")]
        public ActionResult<CreatedResultDto> Add(ProductCreateDto dto)
        {
            return Ok(_productService.Add(dto));
        }
        [HttpPut("{id}")]
        public ActionResult Edit(int id,ProductEditDto dto)
        {
            _productService.Edit(id,dto);
            return NoContent();
        }
        [HttpDelete("")]
        public ActionResult Remove(int id)
        {
            _productService.Remove(id);
            return NoContent();
        }
    }
}
