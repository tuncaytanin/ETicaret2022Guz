using Eticaret.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;

namespace ETicaret.DataAccesLayer.Mappings
{
    public class RoleMap : IEntityTypeConfiguration<Role>
    {
        public void Configure(EntityTypeBuilder<Role> modelbuilder)
        {
            modelbuilder.ToTable("Roles");
            modelbuilder.HasKey(x => x.RoleId);
            modelbuilder.Property(x => x.RoleName).HasMaxLength(100).IsRequired();
            modelbuilder.Property(x => x.RoleDescription).HasMaxLength(200);

            modelbuilder.HasData(new Role
            {
                RoleId = 1,
                RoleName = "Admin",
                RoleStatu = true,
                RoleDescription = "Admin kullanıcıları için oluşturuğumuz role"
            });
        }
    }
}
