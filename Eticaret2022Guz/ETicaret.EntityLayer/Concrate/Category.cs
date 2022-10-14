using ETicaret.EntityLayer.Abstract;

namespace ETicaret.EntityLayer.Concrate
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }
        public string CategoryName { get; set; }
        public bool CategoryStatu { get; set; }

        public short SortKey { get; set; }

        public ICollection<SubCategory>  SubCategories { get; set; }
    }
}
