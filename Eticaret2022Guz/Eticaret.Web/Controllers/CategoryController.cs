using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Web.Services;
using ETicaret.BussinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

namespace Eticaret.Web.Controllers
{
    public class CategoryController : Controller
    {
        private readonly CategoryApiService _categoryApiService;


   //     private readonly ICategoryService _categoryService;

        public CategoryController(CategoryApiService categoryApiService)
        {
            _categoryApiService = categoryApiService;
        }

        [HttpGet]
        public async Task<IActionResult> Index()
        {
            CustomResponseDto<List<Category>> customResponseDto  = await _categoryApiService.GetListAsync();
            return View(customResponseDto.Data);
        }

 
        public async Task<IActionResult> Delete(int id)
        {
            bool sonuc =  await _categoryApiService.DeleteByIdAsync(id);

            return RedirectToAction(nameof(Index));
        }

        [HttpGet]
        public IActionResult Add()
        {
            Category category = new Category();

            return View(category);
        }

        [HttpPost]
        public async Task<IActionResult> Add(Category addCategory)
        {
            addCategory.CategoryStatus = true;

            if (ModelState.IsValid)
            {

                var sonuc = await _categoryApiService.AddAsync(addCategory);
                if (sonuc.StatusCode == 200)
                {
                    return RedirectToAction(nameof(Index));
                }

            }

            return View(addCategory);
        }

        [HttpGet]
        public async Task<IActionResult> Update(int id)
        {
            var sonuc = await _categoryApiService.GetModelByIdAsync(id);
            //List<bool> bools = new List<bool>() { true, false };
            //ViewBag.Status = new SelectList(bools,)

            return View(sonuc.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category updateCategory)
        {
            var sonuc = await _categoryApiService.UpdateAsync(updateCategory);
            return RedirectToAction(nameof(Index));
        }

    }



}
