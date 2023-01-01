using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using ETicaret.BussinessLayer.Concrete;
using Microsoft.AspNetCore.Mvc;
using Microsoft.AspNetCore.Mvc.Rendering;

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

                var sonuc = await _categoryService.AddAsync(addCategory);
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
            var sonuc = await _categoryService.GetModelByIdAsync(id);
            //List<bool> bools = new List<bool>() { true, false };
            //ViewBag.Status = new SelectList(bools,)

            return View(sonuc.Data);
        }

        [HttpPost]
        public async Task<IActionResult> Update(Category updateCategory)
        {
            var sonuc = await _categoryService.UpdateAsync(updateCategory);
            return RedirectToAction(nameof(Index));
        }

    }



}
