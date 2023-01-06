using Eticaret.Core.Dtos.Response;
using Eticaret.Core.Models;
using Eticaret.Core.Services;
using System.Linq.Expressions;

namespace Eticaret.Web.Services
{
    public class CategoryApiService
    {

        private readonly HttpClient _httpClient;
        public CategoryApiService(HttpClient httpClient)
        {
            _httpClient = httpClient;
        }

        public async Task<CustomResponseDto<Category>> AddAsync(Category entity)
        {
            var response = await _httpClient.PostAsJsonAsync("Category/Add", entity);

            if (!response.IsSuccessStatusCode)
                return null;

            var responseBody = await response.Content.ReadFromJsonAsync<CustomResponseDto<Category>>();

            return responseBody;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            var response = await _httpClient.DeleteAsync($"Category/Delete/{id}");

            return response.IsSuccessStatusCode;
        }

        public Task<CustomResponseDto<List<Category>>> Get3CategoryAsync()
        {
            throw new NotImplementedException();
        }

        public Task<CustomResponseDto<Category>> GetAsync(Expression<Func<Category, bool>> filter)
        {
            throw new NotImplementedException();
        }

        public async Task<CustomResponseDto<List<Category>>> GetListAsync(Expression<Func<Category, bool>> filter = null)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<List<Category>>>("Category/GetList");

            return response;
        }

        public async Task<CustomResponseDto<Category>> GetModelByIdAsync(int id)
        {
            var response = await _httpClient.GetFromJsonAsync<CustomResponseDto<Category>>($"Category/GetById/{id}");

            return response;
        }

        public async Task<bool> UpdateAsync(Category entity)
        {
            var response = await _httpClient.PutAsJsonAsync("Category/Update", entity);

            return response.IsSuccessStatusCode;
        }
    }
}
