using ETicaret.EntityLayer.Abstract;

namespace ETicaret.EntityLayer.Concrate
{
    public class Brand: IEntity
    {
        public int BrandId { get; set; }

        public string BrandName { get; set; }

        public bool BrandStatu { get; set; }


        public ICollection<SubCategory> SubCategories { get; set; }

    }
}
