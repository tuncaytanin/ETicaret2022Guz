using ETicaret.BussinessLayer.Abstract;
using ETicaret.DataAccessLayer.Abstracts;
using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.BussinessLayer.Concrete
{
    public class CustomerService : ICustomerService
    {
       private  readonly ICustomerDal _customerDal;

        public CustomerService(ICustomerDal customerDal)
        {
            _customerDal = customerDal;
        }

        public async Task<Customer> AddAsync(Customer customer)
        {
             var addCustomer =   await  _customerDal.AddAsync(customer);

            return addCustomer;
        }

        public async Task<bool> DeleteByIdAsync(int id)
        {
            return await _customerDal.DeleteByIdAsync(id);
        }

        public async Task<Customer> GetAsync(Expression<Func<Customer, bool>> filter)
        {
            return await _customerDal.GetAsync(filter);
            
        }

        public async Task<List<Customer>> GetListAsync(Expression<Func<Customer, bool>> filter = null)
        {

                return await _customerDal.GetListAsync(filter);

        }

        public async Task<Customer> GetModelByIdAsync(int id)
        {
            return await _customerDal.GetModelByIdAsync(id);
        }

        public async Task<Customer> UpdateAsync(Customer customer)
        {
            return await _customerDal.UpdateAsync(customer);
        }
    }
}
