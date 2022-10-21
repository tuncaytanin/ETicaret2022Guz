using ETicaret.EntityLayer.Abstracts;
using System.Collections.Generic;

namespace ETicaret.EntityLayer.Concretes
{
    public class Brand : IEntity
    {
        //Sadece Id yada ClassName+Id yazarsak varsayılan primary key olarak belirlenir.
        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public bool BrandStatu { get; set; }


        public ICollection<SubCategory> SubCategories { get; set; }

    }
}
