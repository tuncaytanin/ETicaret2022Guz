using Eticaret.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.DataAccesLayer.Mappings
{
    public class ProductMap : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
           builder.HasKey(x => x.ProductId);

            builder.Property(x => x.ProductName).IsRequired().HasColumnType("varchar").HasMaxLength(200);

           builder.HasOne(x=>x.Brand).WithMany(y=>y.Products).HasForeignKey(x=>x.BrandId);
            builder.HasOne(x => x.SubCategory).WithMany(y => y.Products).HasForeignKey(z=>z.SubCategoryId);
        }
    }
}
