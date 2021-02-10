using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;
using ShopWithAJAX.Database.EntityModel;

namespace ShopWithAJAX.Database.EF
{
    public class ShopContext : DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options):base(options)
        { }
        //public DbSet<GoodEntity> Goods { get; set; }
        public DbSet<ShopEntity> Shops { get; set; }
        protected override void OnModelCreating(ModelBuilder modelBuilder)
        {
            //modelBuilder.Entity<GoodEntity>().HasOne<ShopEntity>(s=>s.Shop).WithMany(a=>a.Goods).HasForeignKey(d=>d.ShopId);

            var shops = new List<ShopEntity> 
            { 
                new ShopEntity { ShopId = 1, Name = "SmallShop", Adress = "adress1", Phone = "123 456 789", Email = "asqw@mail.com", TimeOfWork = "8:00-20:00"},
                new ShopEntity { ShopId = 2, Name = "MediumShop", Adress = "adress2", Phone = "789 456 123", Email = "zxas@mail.com", TimeOfWork = "9:00-21:00"},
                new ShopEntity { ShopId = 3, Name = "BigShop", Adress = "adress3", Phone = "789 456 123", Email = "qwzx@mail.com", TimeOfWork = "8:00-23:00"}
            };
            //var goods = new List<GoodEntity>
            //{
            //    new GoodEntity { Id = 1, Name = "phone", Price = 10m, Shop = shops[0] },
            //    new GoodEntity { Id = 2, Name = "computer", Price = 10m, Shop = shops[2] },
            //    new GoodEntity { Id = 3, Name = "monitor", Price = 10m, Shop = shops[1] },
            //    new GoodEntity { Id = 4, Name = "laptop", Price = 10m, Shop = shops[2] },
            //    new GoodEntity { Id = 5, Name = "headphones", Price = 10m, Shop = shops[1] },
            //    new GoodEntity { Id = 6, Name = "mouse", Price = 10m, Shop = shops[0] },
            //};

            modelBuilder.Entity<ShopEntity>().HasData(shops);
            //modelBuilder.Entity<GoodEntity>().HasData(goods);
            base.OnModelCreating(modelBuilder);
        }
    }
}
