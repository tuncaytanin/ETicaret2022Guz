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
        DbSet<Category> Categories { get; set; }
        DbSet<Brand> Brands { get; set; }
        DbSet<Adress> Adresses { get; set; }


        protected override void OnConfiguring(DbContextOptionsBuilder optionsBuilder)
        {
            // Sql 
            optionsBuilder.UseSqlServer("Data Source=TANINPC;database=DbETradeMvc22-23-Guz;Integrated Security=True;Connect Timeout=30;Encrypt=False;TrustServerCertificate=False;ApplicationIntent=ReadWrite;MultiSubnetFailover=False");
        }

        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            modelBuilder.ApplyConfiguration(new AdressMap());
            modelBuilder.ApplyConfiguration(new CategoryMap());
            modelBuilder.ApplyConfiguration(new BrandMap());


            //modelBuilder.Entity<Adress>()
            //    .ToTable("Adresler")
            //    .Property(x => x.AdressName).HasMaxLength(50).IsRequired();

        }
    }
}
