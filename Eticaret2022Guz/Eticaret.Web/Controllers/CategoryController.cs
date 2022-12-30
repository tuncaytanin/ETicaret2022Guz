using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.Web.Controllers
{
    public class CategoryController : Controller
    {


        private readonly ICategoryService _categoryService;

        public CategoryController(ICategoryService categoryService)
        {
            _categoryService = categoryService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            CustomResponseDto<List<Category>> customResponseDto  = await _categoryService.GetListAsync();
            return View(customResponseDto.Data);
        }

 
        public async Task<IActionResult> Delete(int id)
        {
            CustomResponseDto<bool> sonuc =  await _categoryService.DeleteByIdAsync(id);

            return RedirectToAction(nameof(Index));
        }

    }
}
