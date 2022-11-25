using ETicaret.DataAccessLayer.Abstracts;
using ETicaret.DataAccessLayer.Concretes.Contexts;
using ETicaret.DataAccessLayer.Repositories;
using ETicaret.EntityLayer.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.EntityFrameWorks
{
    public class EfAdressRepository : EfRepositoyBase<Adress>, IAdressDal
    {
        // EfRepositorybase benim ihityaçlarımı karşılamayan sorguları burada yazıcam..
    }

}
