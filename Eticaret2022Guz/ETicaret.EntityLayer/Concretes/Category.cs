using ETicaret.EntityLayer.Abstracts;
using System.Collections.Generic;

namespace ETicaret.EntityLayer.Concretes
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        public short SortKey { get; set; }

      //  public ICollection<SubCategory> SubCategories { get; set; }
    }
}
