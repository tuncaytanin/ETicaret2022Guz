﻿using Eticaret.Core.Models;
using Eticaret.Repositories;
using ETicaret.DataAccesLayer.Concretes.Contexts;
using ETicaret.DataAccesLayer.Repositories;

using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ETicaret.DataAccesLayer.EntityFrameWorks
{
    public class EfCategoryRepository : EfRepositoyBase<Category>, ICategoryDal
    {

        // Burada generic yani EfRepositoyBase ihityacı karşılamayan ve sadece
        // Cateogry için kullanacağım entity kodlarımı yazacağım yerdir.
        public async Task<List<Category>> Get3Category()
        {
            using (ApplicationDbContext context = new ApplicationDbContext())
            {

                return await context.Set<Category>().Take(3).ToListAsync();
            }
        }
    }

}
