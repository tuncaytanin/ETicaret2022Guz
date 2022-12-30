using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    public class CategoryController : CustomBaseController
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
            //var result = await _ICategoryService.GetListAsync(x => x.CategoryStatus == true); // CustomerResponseData<T>
            //if (result is not null)
            //    return Ok(result);
            return CreateActionResult(await _ICategoryService.GetListAsync(x => x.CategoryStatus == true));
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _ICategoryService.GetModelByIdAsync(id));

        }
        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] Category category)
        {
            return CreateActionResult(await _ICategoryService.AddAsync(category));
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]

        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResult(await _ICategoryService.DeleteByIdAsync(id));
        }


        [HttpGet]
        [Route("[action]")]

        public async Task<IActionResult> GetLast3()
        {
            return this.CreateActionResult(await _ICategoryService.Get3CategoryAsync());

        }

        [HttpPut]
        [Route("[action]")]

        public async Task<IActionResult> Update([FromBody] Category category)
        {
            return CreateActionResult(await _ICategoryService.UpdateAsync(category));
        }

    }
}
