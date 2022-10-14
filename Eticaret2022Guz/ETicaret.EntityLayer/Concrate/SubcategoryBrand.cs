using ETicaret.EntityLayer.Abstract;

namespace ETicaret.EntityLayer.Concrate
{
    public class SubcategoryBrand: IEntity
    {
        public int SubcategoryBrandId { get; set; }

        public int BrandId { get; set; }

        public int SubcategoryId { get; set; }

        public Brand Brand { get; set; }
        public SubCategory SubCategory { get; set; }
    }
}
