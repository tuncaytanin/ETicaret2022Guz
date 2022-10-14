using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataAccessLayer.Repositories;
using ETicaret.EntityLayer.Concrate;

namespace ETicaret.DataAccessLayer.EntityFramework
{
    public class EfEmployeeRepository : EntityRepositoryBase<Employee>, IEmployeeDal
    {

    }
}
