using Eticaret.Core.Dtos.Response;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace Eticaret.Core.Services
{
    public interface IService<T> where T : class
    {
        Task<CustomResponseDto<T>> AddAsync(T entity);
        Task<CustomResponseDto<T>> UpdateAsync(T entity);
        Task<CustomResponseDto<bool>> DeleteByIdAsync(int id);

        Task<CustomResponseDto<List<T>>> GetListAsync(Expression<Func<T, bool>> filter = null);

        Task<CustomResponseDto<T>> GetAsync(Expression<Func<T, bool>> filter);

        Task<CustomResponseDto<T>> GetModelByIdAsync(int id);


    }
}
