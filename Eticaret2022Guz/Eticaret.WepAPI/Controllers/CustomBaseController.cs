using Eticaret.Core.Dtos.Response;
using Microsoft.AspNetCore.Mvc;

namespace Eticaret.WepAPI.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class CustomBaseController : ControllerBase
    {

        public IActionResult CreateActionResult<T>(CustomResponseDto<T> response)
        {
            if (response.StatusCode == 204)
            {
                return new ObjectResult(null) { StatusCode = response.StatusCode };
            }
            return new ObjectResult(response) { StatusCode = response.StatusCode };
        }
    }
}
