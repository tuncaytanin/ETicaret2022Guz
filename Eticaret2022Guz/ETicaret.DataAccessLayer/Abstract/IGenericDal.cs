namespace ETicaret.DataAccessLayer.Abstract
{
    public interface IGenericDal<TEntity> where TEntity : class
    {
        void Insert(TEntity entity);
        void Update(TEntity entity);
        void Delete(TEntity entity);


        List<TEntity>  GetAll();

        TEntity GetModelById(int id);
    }
}
