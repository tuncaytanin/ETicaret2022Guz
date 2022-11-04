using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Abstract
{
    public interface ICustomerService
    {
        Task<Customer> AddAsync(Customer customer);
        Task<Customer> UpdateAsync(Customer customer);
        Task<bool> DeleteByIdAsync(int id);

        Task<List<Customer>> GetListAsync(Expression<Func<Customer, bool>> filter = null);

        Task<Customer> GetAsync(Expression<Func<Customer, bool>> filter);

        Task<Customer> GetModelByIdAsync(int id);
    }
}
