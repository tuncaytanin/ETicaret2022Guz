using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.DataAccessLayer.Mappings
{
    public class BrandMap : IEntityTypeConfiguration<Brand>
    {
        public void Configure(EntityTypeBuilder<Brand> builder)
        {
            builder.HasKey("BrandId");
            builder.Property(x => x.BrandName)
                .HasColumnType("nvarchar")
                .HasMaxLength(50)
                .IsRequired();

            builder.Property(x => x.BrandStatu)
                .HasDefaultValue(true)
                .IsRequired();


            // tablo içerisinde hiçbir kayıt yok ise aşağıdaki kaydın insert eder...
            builder.HasData(new Brand
            {
                BrandId=1,
                BrandStatu=true,
                BrandName ="Adidas"
            });

        }
    }
}
