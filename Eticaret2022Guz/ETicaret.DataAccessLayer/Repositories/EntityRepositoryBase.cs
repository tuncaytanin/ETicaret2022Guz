using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataAccessLayer.Concrate;
using ETicaret.EntityLayer.Abstract;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Repositories
{
    public class EntityRepositoryBase<TEntity> : IGenericDal<TEntity>
        where TEntity : class, IEntity, new()
    {
        public AppDbContext db;
        public DbSet<TEntity> _object;
        public EntityRepositoryBase()
        {
            db = new AppDbContext();
            _object = db.Set<TEntity>();
        }

        public void Delete(TEntity entity)
        {
            _object.Remove(entity);
            db.SaveChanges();
        }

        public  List<TEntity> GetAll()
        {
            return  _object.ToList();
        }

        public TEntity GetModelById(int id)
        {
            return _object.Find(id);
        }

        public void Insert(TEntity entity)
        {
            throw new NotImplementedException();
        }

        public void Update(TEntity entity)
        {
            throw new NotImplementedException();
        }
    }
}
