using Eticaret.Core.Models;
using Eticaret.Repositories;
using ETicaret.DataAccesLayer.Concretes.Contexts;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ETicaret.DataAccesLayer.Repositories
{
    public class EfRepositoyBase<TEntity> : IGenericDal<TEntity>
        where TEntity : class, IEntity, new()
    {
        public async Task<TEntity> AddAsync(TEntity entity)
        {
            // Veritabanı asenkron olarak veriyi ekler... Gelen veri türü neyse o veri türünü ekleri.
            using (ApplicationDbContext context = new ApplicationDbContext()) // Dispoisble yapmamızı sağlıyor. 
            {
                try
                {
                    //context.Set<TEntity>() bu işlem gelen veri türüne göre DbContext mi ayarlar. Dolayısıyla yaptığımız işlemler bu veri tipine göre yapılır.
                    await context.Set<TEntity>().AddAsync(entity);

                    await context.SaveChangesAsync(); // 
                    return entity;
                }
                catch (Exception hata)
                {

                    throw new Exception(hata.Message);
                }


            }


        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                var deleteModel = await context.Set<TEntity>().FindAsync(id);
                if (deleteModel is null)
                    return false;

                context.Set<TEntity>().Remove(deleteModel);
                await context.SaveChangesAsync();
                return true;
            }
        }

        public async Task<TEntity> GetAsync(Expression<Func<TEntity, bool>> filter)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return await context.Set<TEntity>().SingleOrDefaultAsync(filter);
            }
        }

        public async Task<List<TEntity>> GetListAsync(Expression<Func<TEntity, bool>> filter = null)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                if (filter is null)
                    return await context.Set<TEntity>().ToListAsync();
                return await context.Set<TEntity>().Where(filter).ToListAsync();

            }
        }

        public async Task<TEntity> GetModelByIdAsync(int id)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                return await context.Set<TEntity>().FindAsync(id);
            }
        }

        public async Task<TEntity> UpdateAsync(TEntity entity)
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {
                context.Set<TEntity>().Update(entity);

                await context.SaveChangesAsync();

                return entity;
            }
        }
    }
}
