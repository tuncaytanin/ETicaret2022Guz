using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Repositories;
using System.Collections.Generic;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
    public class CategoryService : Service<Category>, ICategoryService
    {

        private readonly ICategoryDal _categoryDal;

        public CategoryService(ICategoryDal categoryDal, IGenericDal<Category> genericDal) : base(genericDal)
        {
            _categoryDal = categoryDal;
        }

        //public async Task<Category> AddAsync(Category category)
        //{
        //  return  await _categoryDal.AddAsync(category);
        //}

        //public async Task<bool> DeleteByIdAsync(int id)
        //{
        //    return  await _categoryDal.DeleteByIdAsync(id);
        //}

        public async Task<CustomResponseDto<List<Category>>> Get3CategoryAsync()
        {
            var categories = await _categoryDal.Get3Category();
            return CustomResponseDto<List<Category>>.Succes(200, categories);
        }

        //public async Task<Category> GetAsync(Expression<Func<Category, bool>> filter)
        //{
        //    return await _categoryDal.GetAsync(filter);
        //}

        //public async Task<List<Category>> GetListAsync(Expression<Func<Category, bool>> filter = null)
        //{
        //    var categories = await _categoryDal.GetListAsync(filter);

        //    return categories;
        //}

        //public async Task<Category> GetModelByIdAsync(int id)
        //{
        //    return await _categoryDal.GetModelByIdAsync(id);
        //}

        //public async Task<Category> UpdateAsync(Category category)
        //{
        //    return await _categoryDal.UpdateAsync(category);
        //}
    }
}
