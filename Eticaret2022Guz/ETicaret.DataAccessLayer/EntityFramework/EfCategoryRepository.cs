using ETicaret.DataAccessLayer.Abstract;
using ETicaret.DataAccessLayer.Repositories;
using ETicaret.EntityLayer.Concrate;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.EntityFramework
{
    public class EfCategoryRepository : EntityRepositoryBase<Category>,ICategoryDal
    {
    }
}
