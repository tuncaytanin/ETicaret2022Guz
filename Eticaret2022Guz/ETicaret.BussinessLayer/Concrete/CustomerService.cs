using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Repositories;

namespace ETicaret.BussinessLayer.Concrete
{
    public class CustomerService : Service<Customer>, ICustomerService
    {
        private readonly ICustomerDal _customerDal;

        //private readonly AppSettings _appSettings;

        public CustomerService(IGenericDal<Customer> genericDal, ICustomerDal customerDal) : base(genericDal)
        {
            _customerDal = customerDal;
            //_appSettings = appSettings.Value;
        }



        //public async Task<Customer> AddAsync(Customer customer)
        //{
        //     var addCustomer =   await  _customerDal.AddAsync(customer);

        //    return addCustomer;
        //}

        ////public async Task<AccessToken> Authenticate(CustomerForLoginDto customerForLoginDto)
        ////{
        ////    var customer = await _customerDal.GetAsync(x => x.CustomerName == customerForLoginDto.CustomerUserName && x.CustomerPassword == customerForLoginDto.CustomerPassword);

        ////    if (customer is null)
        ////        return null;

        ////    // Customer AccessToken ExpiraDates Check ?

        ////    //if (customer.TokenExpireDate < DateTime.UtcNow || customer.TokenExpireDate == null ||string.IsNullOrEmpty(customer.Token))
        ////    //{

        ////    //}

        ////    var tokenHandler = new JwtSecurityTokenHandler();
        ////    var key = Encoding.ASCII.GetBytes(_appSettings.SecurityKey);

        ////    // Token Tarifini Yapıyoruz..
        ////    var tokenDescriptor = new SecurityTokenDescriptor()
        ////    {
        ////        Subject = new ClaimsIdentity(new[] {
        ////            new Claim(ClaimTypes.Name,customer.CustomerId.ToString())
        ////        }),
        ////        Expires = DateTime.Now.AddDays(7),
        ////        SigningCredentials = new SigningCredentials(new SymmetricSecurityKey(key), SecurityAlgorithms.HmacSha256)
        ////    };

        ////    var token = tokenHandler.CreateToken(tokenDescriptor);

        ////    AccessToken accessToken = new AccessToken()
        ////    {
        ////        Expration = (DateTime)tokenDescriptor.Expires,
        ////        Token = tokenHandler.WriteToken(token),
        ////        UserId = customer.CustomerId,
        ////        UserName = customer.CustomerUserName
        ////    };
        ////    return await Task.Run(() => accessToken);

        ////}

        //public async Task<bool> DeleteByIdAsync(int id)
        //{
        //    return await _customerDal.DeleteByIdAsync(id);
        //}

        //public async Task<Customer> GetAsync(Expression<Func<Customer, bool>> filter)
        //{
        //    return await _customerDal.GetAsync(filter);

        //}

        //public async Task<List<Customer>> GetListAsync(Expression<Func<Customer, bool>> filter = null)
        //{

        //        return await _customerDal.GetListAsync(filter);

        //}

        //public async Task<Customer> GetModelByIdAsync(int id)
        //{
        //    return await _customerDal.GetModelByIdAsync(id);
        //}

        //public async Task<Customer> UpdateAsync(Customer customer)
        //{
        //    return await _customerDal.UpdateAsync(customer);
        //}
    }


}
