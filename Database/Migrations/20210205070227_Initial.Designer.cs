﻿// <auto-generated />
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Infrastructure;
using Microsoft.EntityFrameworkCore.Metadata;
using Microsoft.EntityFrameworkCore.Migrations;
using Microsoft.EntityFrameworkCore.Storage.ValueConversion;
using ShopWithAJAX.Database.EF;

namespace Database.Migrations
{
    [DbContext(typeof(ShopContext))]
    [Migration("20210205070227_Initial")]
    partial class Initial
    {
        protected override void BuildTargetModel(ModelBuilder modelBuilder)
        {
#pragma warning disable 612, 618
            modelBuilder
                .UseIdentityColumns()
                .HasAnnotation("Relational:MaxIdentifierLength", 128)
                .HasAnnotation("ProductVersion", "5.0.2");

            modelBuilder.Entity("ShopWithAJAX.Database.EntityModel.ShopEntity", b =>
                {
                    b.Property<int>("ShopId")
                        .ValueGeneratedOnAdd()
                        .HasColumnType("int")
                        .UseIdentityColumn();

                    b.Property<string>("Adress")
                        .HasColumnType("nvarchar(50)");

                    b.Property<string>("Email")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Name")
                        .HasColumnType("nvarchar(max)");

                    b.Property<string>("Phone")
                        .HasColumnType("nvarchar(max)");

                    b.HasKey("ShopId");

                    b.ToTable("Shops");

                    b.HasData(
                        new
                        {
                            ShopId = 1,
                            Adress = "adress1",
                            Email = "asqw@mail.com",
                            Name = "SmallShop",
                            Phone = "123 456 789"
                        },
                        new
                        {
                            ShopId = 2,
                            Adress = "adress2",
                            Email = "zxas@mail.com",
                            Name = "MediumShop",
                            Phone = "789 456 123"
                        },
                        new
                        {
                            ShopId = 3,
                            Adress = "adress3",
                            Email = "qwzx@mail.com",
                            Name = "BigShop",
                            Phone = "789 456 123"
                        });
                });
#pragma warning restore 612, 618
        }
    }
}
