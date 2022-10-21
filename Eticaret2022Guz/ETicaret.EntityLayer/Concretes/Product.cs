using ETicaret.EntityLayer.Abstracts;

namespace ETicaret.EntityLayer.Concretes
{
    public class Product : IEntity
    {
        public int ProductId { get; set; }
        public string ProductName { get; set; }

        public string ProductCode { get; set; }

        public string ProductDescription { get; set; }

        public int SubCategoryId { get; set; }

        public SubCategory SubCategory { get; set; }
    }
}
