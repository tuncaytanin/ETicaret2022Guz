using Eticaret.Core.Models;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;

namespace ETicaret.DataAccesLayer.Mappings
{
    /// <summary>
    /// Customer entity veritabanı modellemesi
    /// </summary>
    public class CustomerMap : IEntityTypeConfiguration<Customer>
    {

        public void Configure(EntityTypeBuilder<Customer> modelBuilder)
        {
            modelBuilder.ToTable("Customers")
                          .Property(e => e.CustomerUserName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();


            modelBuilder.HasKey("CustomerId");

            modelBuilder.Property(x => x.CustomerEmail).HasColumnType("varchar").HasMaxLength(100).IsRequired();

            modelBuilder.Property(x => x.CustomerLastName).HasColumnType("varchar").HasMaxLength(50).IsRequired();

            modelBuilder.Property(x => x.BirthDay).HasColumnType("date");

            modelBuilder.Property(x => x.CustomerStatus).HasColumnName("CustomerStatus").HasDefaultValue(true).IsRequired();

            modelBuilder.Property(x => x.CustomerName).HasColumnName("CustomerName").HasMaxLength(50).IsRequired();

            modelBuilder.Property(x => x.CreateDate
                ).HasColumnName("datetime").HasDefaultValueSql("getdate()");


            modelBuilder.Property(x => x.PhoneNumber).HasColumnName("varchar").HasMaxLength(15);


            // Cutomer tablosundad veri yoksa aşağıdaki veriyi kaydet oluyor...
            modelBuilder.HasData(new Customer
            {
                CustomerId = 1,
                CustomerEmail = "tt@gmail.com",
                CustomerLastName = "Tanin",
                CustomerName = "Tuncay",
                CreateDate = DateTime.Now,
                CustomerUserName = "tt",
                BirthDay = Convert.ToDateTime("2000-01-01"),
                CustomerStatus = true,
                PhoneNumber = "+905327411235"
            });
            //modelBuilder.Entity<Adress>()
            //    .ToTable("Adresler")
            //    .Property(x => x.AdressName).HasMaxLength(50).IsRequired();

        }

    }
}
