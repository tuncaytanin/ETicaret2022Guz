using ETicaret.EntityLayer.Abstracts;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Abstracts
{
    public interface IGenericDal<TEntity> where TEntity : class, IEntity, new()
    {
        /// <summary>
        /// Ekleme işle.
        /// </summary>
        /// <param name="entity"></param>
        /// <returns></returns>
        Task<TEntity> AddAsync(TEntity entity);
        Task<TEntity> UpdateAsync(TEntity entity);
        Task<bool> DeleteByIdAsync(int id);


        Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null);

        Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter);

        Task<TEntity> GetModelByIdAsync(int id);
    }

}
