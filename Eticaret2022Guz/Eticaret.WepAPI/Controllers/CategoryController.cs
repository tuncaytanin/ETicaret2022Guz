using ETicaret.BussinessLayer.Abstract;
using ETicaret.BussinessLayer.Concrete;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CategoryController : ControllerBase
    {

        private readonly ICategoryService _ICategoryService;

        public CategoryController(ICategoryService ICategoryService)
        {
            _ICategoryService = ICategoryService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
            var result = await _ICategoryService.GetListAsync(x => x.CategoryStatus == true);
            if (result is not null)
                return Ok(result);
            return NotFound(result);
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _ICategoryService.GetModelByIdAsync(id);
            if (result is not null)
                return Ok(result);
            return NotFound(result);
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] Category category)
        {
            var result = await _ICategoryService.AddAsync(category);
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            var  result = await _ICategoryService.DeleteByIdAsync(id);
            if (result)
                return Ok(result);
            return NotFound(result);
        }


        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> GetLast3()
        {
            var result = await _ICategoryService.Get3CategoryAsync();
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

        [HttpPut]
        [Route("[action]")]

        public async Task<IActionResult> Update([FromBody] Category category)
        {
            var result = await _ICategoryService.UpdateAsync(category);
            if (result is not null)
                return Ok(result);
            return BadRequest(result);
        }

    }
}
