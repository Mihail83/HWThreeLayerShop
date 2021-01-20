using System;
using System.Collections.Generic;
using System.Text;
using Microsoft.EntityFrameworkCore;

using HWThreeLayerShop.DAL.DalModels;

namespace HWThreeLayerShop.DAL.EF
{
    public class ShopContext :DbContext
    {
        public ShopContext(DbContextOptions<ShopContext> options) : base(options)
        {
            
        }
        public DbSet<Good> Goods { get; set; }
        public DbSet<Catalog> Catalogs { get; set; }
        //protected override void OnModelCreating(ModelBuilder modelBuilder)
        //{
        //    var catMobilePhone = new Catalog { Id = 1, Name = "Mobile Phone", Goods = new List<Good>() };
        //    var catLaptop = new Catalog { Id = 2, Name = "Laptop", Goods = new List<Good>() };
        //    var catHeadPhones = new Catalog { Id = 3, Name = "HeadPhones", Goods = new List<Good>() };
        //    var catComputer = new Catalog { Id = 4, Name = "Personal Computer", Goods = new List<Good>() };

        //    modelBuilder.Entity<Catalog>().HasData(new Catalog[] { catMobilePhone, catLaptop, catHeadPhones, catComputer });

        //    modelBuilder.Entity<Good>().HasData(new Good[]
        //    {
        //        new Good{Id=1, Name="Huawei", Price=5m, Catalogs= new List<Catalog>{ catMobilePhone } },
        //        new Good{Id=2, Name="IPhone", Price=50m, Catalogs= new List<Catalog>{ catMobilePhone } } },
        //        new Good { Id = 3, Name = "Asus", Price = 50m, Catalogs = new List<Catalog> { catLaptop } },
        //        new Good { Id = 4, Name = "HP", Price = 55m, Catalogs = new List<Catalog> { catLaptop } },
        //        new Good { Id = 5, Name = "NoNameHeadPhones", Price = 2m, Catalogs = new List<Catalog> { catHeadPhones } },
        //        new Good { Id = 6, Name = "Sven", Price = 20m, Catalogs = new List<Catalog> { catHeadPhones } },
        //        new Good { Id = 7, Name = "Gigabyte", Price = 100m, Catalogs = new List<Catalog> { catComputer } },
        //        new Good { Id = 8, Name = "IPhone", Price = 500m, Catalogs = new List<Catalog> { catComputer } });
        //}
    }
}
