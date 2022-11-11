using ETicaret.BussinessLayer.Abstract;
using ETicaret.BussinessLayer.Concrete;
using ETicaret.EntityLayer.Concretes;
using Microsoft.AspNetCore.Http;
using Microsoft.AspNetCore.Mvc;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eticaret.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomerController : ControllerBase
    {
       private ICustomerService _customerService;

        public CustomerController(ICustomerService customerService)
        {
            _customerService = customerService;
        }

        [HttpGet]
        [Route("[action]")]
        public async Task<IActionResult> GetList()
        {
          var result=  await _customerService.GetListAsync(x => x.CustomerStatus == true);
            if (result is not null)
                return Ok(result);
            return BadRequest();
        }

        [HttpGet]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> GetById(int id)
        {
            var result = await _customerService.GetModelByIdAsync(id);
            if (result is not null)
                return Ok(result);
            return NotFound();
        }

        [HttpPost]
        [Route("[action]")]
        public async Task<IActionResult> Add([FromBody] Customer customer)
        {
            var result = await _customerService.AddAsync(customer);
            if (result is not null)
                return Ok(customer);
            return BadRequest(result);
        }


        [HttpPut]
        [Route("[action]")]
        public async Task<IActionResult> Update([FromBody] Customer customer)
        {
            var result = await _customerService.UpdateAsync(customer);
            if (result is not null)
                return Ok(result);
            
            return BadRequest(result);
        }

        [HttpDelete]
        [Route("[action]/{id:int}")]
        public async Task<IActionResult> Delete(int id)
        {
            var result = await _customerService.DeleteByIdAsync(id);
            if (result)
                return Ok(result);
            
            return BadRequest(result);
        }

    }
}
