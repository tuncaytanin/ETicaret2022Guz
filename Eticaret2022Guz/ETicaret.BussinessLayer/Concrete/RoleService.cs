using Eticaret.Core.Models;
using Eticaret.Core.Services;
using Eticaret.Repositories;

namespace ETicaret.BussinessLayer.Concrete
{
    public class RoleService : Service<Role>, IRolService
    {
        private readonly IRolDal _rolDal;

        public RoleService(IGenericDal<Role> genericDal, IRolDal rolDal) : base(genericDal)
        {
            _rolDal = rolDal;
        }
    }


}
