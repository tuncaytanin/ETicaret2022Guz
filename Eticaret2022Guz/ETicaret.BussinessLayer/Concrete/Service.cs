using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Services;
using Eticaret.Repositories;
using System;
using System.Collections.Generic;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
    public class Service<T> : IService<T> where T : class
    {
        private readonly IGenericDal<T> _genericDal;
        public Service(IGenericDal<T> genericDal)
        {
            _genericDal = genericDal;
        }
        public async Task<CustomResponseDto<T>> AddAsync(T entity)
        {
            try
            {
                var addedEntity = await _genericDal.AddAsync(entity);

                if (addedEntity is not null)
                {
                    return CustomResponseDto<T>.Succes(200, addedEntity);
                }
            }
            catch (Exception hata)
            {

                return CustomResponseDto<T>.Fail(404, $"{typeof(T)} eklenirken beklenmedik bir hata oluştu.{hata.Message}");
            }


            return CustomResponseDto<T>.Fail(404, $"{typeof(T)} eklenirken beklenmedik bir hata oluştu");

        }

        public async Task<CustomResponseDto<bool>> DeleteByIdAsync(int id)
        {
           // var deleteEntity = await _genericDal.GetModelByIdAsync(id);
  
                var sonuc = await _genericDal.DeleteByIdAsync(id);
            if (sonuc)
            {
                return CustomResponseDto<bool>.Succes(200, sonuc);
            }

            return CustomResponseDto<bool>.Fail(404, $"{id} bulunamadığı için silinemedi");
        }

        public async Task<CustomResponseDto<T>> GetAsync(Expression<Func<T, bool>> filter)
        {
            var entity = await _genericDal.GetAsync(filter);

            if (entity is not null)
                return CustomResponseDto<T>.Succes(200, entity);
            return CustomResponseDto<T>.Fail(400, $"{typeof(T)} bulunamadı");
        }

        public async Task<CustomResponseDto<List<T>>> GetListAsync(Expression<Func<T, bool>> filter = null)
        {
            // Categori GetList, Customer GetList, Product GetList ..... Bütün getList ler buradan çağırılıyor...

            var entities = await _genericDal.GetListAsync(filter);

            if (entities is null)
            {
                return CustomResponseDto<List<T>>.Fail(400, $"{typeof(T)} bulunamadı");
            }

            return CustomResponseDto<List<T>>.Succes(200, entities);
        }

        public async Task<CustomResponseDto<T>> GetModelByIdAsync(int id)
        {
            var entity = await _genericDal.GetModelByIdAsync(id);
            if (entity is not null)
                return CustomResponseDto<T>.Succes(200, entity);

            return CustomResponseDto<T>.Fail(400, $"{typeof(T)} - Id:{id} bulunamadı");
        }

        public async Task<CustomResponseDto<T>> UpdateAsync(T entity)
        {
            var updatedEntity = await _genericDal.UpdateAsync(entity);

            if (updatedEntity is not null)
            {
                return CustomResponseDto<T>.Succes(200, entity);
            }
            return CustomResponseDto<T>.Fail(400, $"{typeof(T)}  bulunamadığı için güncellenemedi");
        }
    }
}
