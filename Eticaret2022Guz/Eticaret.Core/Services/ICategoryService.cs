
using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eticaret.Core.Services
{
    public interface ICategoryService : IService<Category>
    {
        Task<CustomResponseDto<List<Category>>> Get3CategoryAsync();
    }

}
