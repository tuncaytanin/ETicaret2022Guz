using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{

    public class RoleController : CustomBaseController
    {

        private readonly IRolService _rolService;

        public RoleController(IRolService rolService)
        {
            _rolService = rolService;
        }
        [HttpGet]

        public async Task<IActionResult> GetList()
        {
            return CreateActionResult(await _rolService.GetListAsync());
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _rolService.GetModelByIdAsync(id));
        }

        [HttpPost]

        public async Task<IActionResult> Add([FromBody] Role role)
        {
            return CreateActionResult(await _rolService.AddAsync(role));
        }


        [HttpPut]

        public async Task<IActionResult> Update([FromBody] Role role)
        {
            return CreateActionResult(await _rolService.UpdateAsync(role));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResult(await _rolService.DeleteByIdAsync(id));
        }
    }
}
