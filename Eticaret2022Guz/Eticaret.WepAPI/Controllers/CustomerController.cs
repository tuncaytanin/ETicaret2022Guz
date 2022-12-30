using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Microsoft.AspNetCore.Mvc;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    public class CustomerController : CustomBaseController
    {
        private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]

        public async Task<IActionResult> GetList()
        {
            return CreateActionResult(await _customerService.GetListAsync(x => x.CustomerStatus == true));
        }

        [HttpGet]
        [Route("{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            return CreateActionResult(await _customerService.GetModelByIdAsync(id));
        }

        [HttpPost]

        public async Task<IActionResult> Add([FromBody] Customer customer)
        {
            return CreateActionResult(await _customerService.AddAsync(customer));
        }


        [HttpPut]

        public async Task<IActionResult> Update([FromBody] Customer customer)
        {
            return CreateActionResult(await _customerService.UpdateAsync(customer));
        }

        [HttpDelete]
        [Route("{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            return CreateActionResult(await _customerService.DeleteByIdAsync(id));
        }

        //[AllowAnonymous] // Authorize olmadan erişilebilirlik sağlıyor...
        //[HttpPost]
        //[Route("[action]")]
        //public async Task<IActionResult> Authenticate([FromBody] CustomerForLoginDto customerForLoginDto)
        //{
        //    var result = await _customerService.Authenticate(customerForLoginDto);
        //    if (result is not null)
        //        return Ok(result);
        //    return BadRequest(result);
        //}

    }
}
