using System.Collections.Generic;

namespace Eticaret.Core.Models
{
    public class SubCategory : IEntity
    {
        public int SubCategoryId { get; set; }

        public string SubCategoryName { get; set; }
        public bool SubCategoryStatu { get; set; }

        public int CategoryId { get; set; }
        public Category Category { get; set; }
        public short SortKey { get; set; }

        public ICollection<Product> Products { get; set; }

        public ICollection<Brand> Brands { get; set; }

    }
}
