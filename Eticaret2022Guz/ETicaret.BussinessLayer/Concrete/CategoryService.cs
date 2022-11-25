using ETicaret.BussinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstracts;
using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
    public class CategoryService : ICategoryService
    {

        private readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal)
        {
            _categoryDal = categoryDal;
        }

        public async Task<Category> AddAsync(Category category)
        {
          return  await _categoryDal.AddAsync(category);
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            return  await _categoryDal.DeleteByIdAsync(id);
        }

        public async Task<List<Category>> Get3CategoryAsync()
        {
            return await _categoryDal.Get3Category();
        }

        public async Task<Category> GetAsync(Expression<Func<Category, bool>> filter)
        {
            return await _categoryDal.GetAsync(filter);
        }

        public async Task<List<Category>> GetListAsync(Expression<Func<Category, bool>> filter = null)
        {
            return await _categoryDal.GetListAsync(filter);
        }

        public async Task<Category> GetModelByIdAsync(int id)
        {
            return await _categoryDal.GetModelByIdAsync(id);
        }

        public async Task<Category> UpdateAsync(Category category)
        {
            return await _categoryDal.UpdateAsync(category);
        }
    }
}
