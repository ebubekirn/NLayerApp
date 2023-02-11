﻿using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core.Models;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Seeds
{
    internal class ProductSeed : IEntityTypeConfiguration<Product>
    {
        public void Configure(EntityTypeBuilder<Product> builder)
        {
            builder.HasData(
                new Product { Id = 1, CaregoryId = 1, Name = "Kalem 1", Price = 100, Stock = 20, CreatedDate = DateTime.Now }, 
                new Product { Id = 2, CaregoryId = 1, Name = "Kalem 2", Price = 200, Stock = 30, CreatedDate = DateTime.Now },
                new Product { Id = 3, CaregoryId = 1, Name = "Kalem 3", Price = 600, Stock = 60, CreatedDate = DateTime.Now },
                new Product { Id = 4, CaregoryId = 2, Name = "Kitap 1", Price = 600, Stock = 60, CreatedDate = DateTime.Now },
                new Product { Id = 5, CaregoryId = 2, Name = "Kitap 2", Price = 500, Stock = 50, CreatedDate = DateTime.Now });
        }
    }
}
