namespace Eticaret.Core.Models
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
