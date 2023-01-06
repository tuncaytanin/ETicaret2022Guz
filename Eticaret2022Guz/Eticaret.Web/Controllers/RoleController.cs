//using Eticaret.Core.Dtos.Response;
//using Eticaret.Core.Models;
//using Eticaret.Core.Services;
//using Microsoft.AspNetCore.Mvc;

//namespace Eticaret.Web.Controllers
//{
//    public class RoleController : Controller
//    {
//        private readonly IRolService _rolService;
//        public RoleController(IRolService rolService)
//        {
//            _rolService = rolService;
//        }
//        [HttpGet]
//        public async Task<IActionResult> Index()
//        {
//            var sonuc = await _rolService.GetListAsync();

//            return View(sonuc.Data);
//        }


//        public async Task<IActionResult> Delete(int id)
//        {
//            CustomResponseDto<bool> sonuc = await _rolService.DeleteByIdAsync(id);

//            return RedirectToAction(nameof(Index));
//        }

//        [HttpGet]
//        public IActionResult Add()
//        {

//            return View(new Role());
//        }

//        [HttpPost]
//        public async Task<IActionResult> Add(Role addRole)
//        {
//            addRole.RoleStatu = true;

//            if (ModelState.IsValid)
//            {

//                var sonuc = await _rolService.AddAsync(addRole);
//                if (sonuc.StatusCode == 200)
//                {
//                    return RedirectToAction(nameof(Index));
//                }

//            }

//            return View(addRole);
//        }

//        [HttpGet]
//        public async Task<IActionResult> Update(int id)
//        {
//            var sonuc = await _rolService.GetModelByIdAsync(id);
//            //List<bool> bools = new List<bool>() { true, false };
//            //ViewBag.Status = new SelectList(bools,)

//            return View(sonuc.Data);
//        }

//        [HttpPost]
//        public async Task<IActionResult> Update(Role updateRole)
//        {
//            var sonuc = await _rolService.UpdateAsync(updateRole);
//            return RedirectToAction(nameof(Index));
//        }

//    }



//}
