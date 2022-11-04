using ETicaret.DataAccessLayer.Mappings;
using ETicaret.EntityLayer.Concretes;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace ETicaret.DataAccessLayer.Concretes.Contexts
{
    /// <summary>
    /// Ef  Db Process....
    /// </summary>
    public class ApplicationDbContext:DbContext
    {
        //DbSet<Category> Categories { get; set; }
        //DbSet<Brand> Brands { get; set; }
        //DbSet<Adress> Adresses { get; set; }

        DbSet<Customer> Customers { get; set; }


        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options) : base(options)
        {

        }

        public ApplicationDbContext()
        {

        }


       
        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sql 
            optionsBuilder.UseSqlServer("Data Source=TANINPC;database=DbETradeMvc22-23-Guz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.ApplyConfiguration(new AdressMap());
            //modelBuilder.ApplyConfiguration(new CategoryMap());
            //modelBuilder.ApplyConfiguration(new BrandMap());


            modelBuilder.Entity<Customer>()
                .ToTable("Customers")
                .Property(e => e.CustomerUserName).HasColumnType("nvarchar").HasMaxLength(50).IsRequired();


            modelBuilder.Entity<Customer>().HasKey("CustomerId");

            modelBuilder.Entity<Customer>()
                .Property(x => x.CustomerEmail).HasColumnType("varchar").HasMaxLength(100).IsRequired();

            modelBuilder.Entity<Customer>()
         .Property(x => x.CustomerLastName).HasColumnType("varchar").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Customer>()
         .Property(x => x.BirthDay).HasColumnType("date");

            modelBuilder.Entity<Customer>()
         .Property(x => x.CustomerStatus).HasColumnName("CustomerStatus").HasDefaultValue(true).IsRequired();

            modelBuilder.Entity<Customer>()
            .Property(x => x.CustomerName).HasColumnName("CustomerName").HasMaxLength(50).IsRequired();

            modelBuilder.Entity<Customer>()
                .Property(x => x.CreateDate
                ).HasColumnName("datetime").HasDefaultValueSql("getdate()");


            modelBuilder.Entity<Customer>()
.Property(x => x.PhoneNumber).HasColumnName("varchar").HasMaxLength(15);


            // Cutomer tablosundad veri yoksa aşağıdaki veriyi kaydet oluyor...
            modelBuilder.Entity<Customer>().HasData(new Customer
            {
                CustomerId =1,
                CustomerEmail ="tt@gmail.com",
                CustomerLastName ="Tanin",
                CustomerName ="Tuncay",
                CreateDate = DateTime.Now,
                CustomerUserName ="tt",
                BirthDay = Convert.ToDateTime("2000-01-01"),
                CustomerStatus =true,
                PhoneNumber = "+905327411235"
            });
            //modelBuilder.Entity<Adress>()
            //    .ToTable("Adresler")
            //    .Property(x => x.AdressName).HasMaxLength(50).IsRequired();

        }
    }
}
