
using Eticaret.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace Eticaret.Repositories
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<List<Category>> Get3Category();
    }

}
