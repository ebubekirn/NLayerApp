using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using NLayer.Core;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace NLayer.Repository.Configurations
{
    internal class CategoryConfiguraiton : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasKey(x => x.Id); // Id primary key olsun dedik
            builder.Property(x => x.Id).UseIdentityColumn(); // Id birer birer artsın dedik.
            builder.Property(x => x.Name).IsRequired().HasMaxLength(50); // Name null olmasın ve max 50 karakter olsun dedik.
            builder.ToTable("Categories"); // Tablonun ismini belirtiyoruz. Defauşt olarak AppDbContext teki adı alıyor. 
        }
    }
}
