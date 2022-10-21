using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.DataAccessLayer.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            //builder.ToTable("Category");
            //builder.HasNoKey(); // Categeory tablosunda primarytkey olmamasını sağlar

            //builder.HasKey("CategoryId");

            builder.Property(x => x.SortKey).HasDefaultValue(0);
            builder.Property(x => x.CategoryStatu).HasDefaultValue(true);
            builder.Property(x => x.CategoryName).HasColumnType("nvarchar").HasMaxLength(100).IsRequired();

            builder.HasData(new Category
            {
                CategoryId=1,
                CategoryStatu=true,
                CategoryName="Elektronik",
                SortKey =1
            });
        }
    }
}
