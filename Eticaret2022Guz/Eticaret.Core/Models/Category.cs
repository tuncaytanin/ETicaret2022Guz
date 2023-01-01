using System.ComponentModel.DataAnnotations;

namespace Eticaret.Core.Models
{
    public class Category : IEntity
    {
        public int CategoryId { get; set; }

        [Display(Name ="Kategori Adı")]
        public string CategoryName { get; set; }
        public bool CategoryStatus { get; set; }

        [Display(Name = "Sıra Numarası")]
        public short SortKey { get; set; }

        //  public ICollection<SubCategory> SubCategories { get; set; }
    }
}
