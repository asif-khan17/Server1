using System;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using ORM_Assignment_2;

namespace ORM_Assignment_2.Migrations
{
    [DbContext(typeof(UpdateAndProduct))]
    [Migration("20170222100439_New_1 migrations")]
    partial class New_1migrations
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
            modelBuilder
                .HasAnnotation("ProductVersion", "1.1.0-rtm-22752")
                .HasAnnotation("SqlServer:ValueGenerationStrategy", SqlServerValueGenerationStrategy.IdentityColumn);

            modelBuilder.Entity("ORM_Assignment_2.ProductModel", b =>
                {
                    b.Property<int>("Pid")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("HomePageUrl")
                        .IsRequired()
                        .HasMaxLength(50);

                    b.Property<string>("Pdescription")
                        .HasMaxLength(50);

                    b.Property<string>("Pname")
                        .HasMaxLength(50);

                    b.HasKey("Pid");

                    b.ToTable("products_1");
                });

            modelBuilder.Entity("ORM_Assignment_2.UpdateModel", b =>
                {
                    b.Property<int>("Id")
                        .ValueGeneratedOnAdd();

                    b.Property<string>("Description")
                        .HasMaxLength(50);

                    b.Property<string>("Name")
                        .HasMaxLength(50);

                    b.Property<int>("Pid");

                    b.HasKey("Id");

                    b.HasIndex("Pid");

                    b.ToTable("updates");
                });

            modelBuilder.Entity("ORM_Assignment_2.UpdateModel", b =>
                {
                    b.HasOne("ORM_Assignment_2.ProductModel", "ProductModel")
                        .WithMany("Updates")
                        .HasForeignKey("Pid")
                        .OnDelete(DeleteBehavior.Cascade);
                });
        }
    }
}
