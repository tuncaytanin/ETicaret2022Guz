using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Abstract
{
    public interface ICategoryService
    {
        Task<Category> AddAsync(Category category);
        Task<Category> UpdateAsync(Category category);
        Task<bool> DeleteByIdAsync(int id);

        Task<List<Category>> GetListAsync(Expression<Func<Category, bool>> filter = null);

        Task<Category> GetAsync(Expression<Func<Category, bool>> filter);

        Task<Category> GetModelByIdAsync(int id);

        Task<List<Category>> Get3CategoryAsync();
    }
}
