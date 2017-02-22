using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace ORM_Assignment_2
{
    public class UpdateAndProduct: DbContext
    {
         public DbSet<UpdateModel> updates { get; set; }
         public DbSet<ProductModel> products_1 { get; set; }

       protected override void OnConfiguring(DbContextOptionsBuilder builder)
        {


            builder.UseSqlServer(@"Server=(localdb)\mssqllocaldb;Database=UpdateandProduct.NewDb");



        }
        protected override void OnModelCreating(ModelBuilder modelbuilder)
        {


            modelbuilder.Entity<ProductModel>()
                .Property(b => b.HomePageUrl)
                .IsRequired();

        }


    }
}
