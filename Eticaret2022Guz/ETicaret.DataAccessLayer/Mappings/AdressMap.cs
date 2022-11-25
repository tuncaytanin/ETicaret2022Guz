using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Mappings
{
    public class AdressMap : IEntityTypeConfiguration<Adress>
    {
        public void Configure(EntityTypeBuilder<Adress> builder)
        {

            // create database Adress

            builder.Property(x => x.AdressName)
                .HasColumnType("nvarchar")
                .HasMaxLength(100)
                .IsRequired();


            /* 
             * add column AdressName nvarchar(500) not null
             * 
             */

            builder.HasKey(x => x.AdressId);

            builder.Property(x => x.AdressDescription)
                .HasColumnType("nvarchar")
                .HasMaxLength(500)
                .IsRequired();

            /* 
             * add column nvarchar(500) not null
             * 
             */

            builder.Property(x => x.CityName)
                .HasColumnType("nvarchar")
                .HasMaxLength(50);

            builder.Property(x => x.TownName)
                .HasColumnName("nvarchar")
                .HasMaxLength(50);


        }
    }
}
