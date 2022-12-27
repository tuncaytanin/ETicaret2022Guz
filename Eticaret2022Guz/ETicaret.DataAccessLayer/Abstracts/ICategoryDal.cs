using Eticaret.Core.Models;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Abstracts
{
    public interface ICategoryDal : IGenericDal<Category>
    {
        Task<List<Category>> Get3Category();
    }

}
