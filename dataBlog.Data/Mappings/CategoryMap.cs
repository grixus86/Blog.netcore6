using libBlog.Entity.Entities;
using Microsoft.EntityFrameworkCore;
using Microsoft.EntityFrameworkCore.Metadata.Builders;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBlog.Data.Mappings
{
    public class CategoryMap : IEntityTypeConfiguration<Category>
    {
        public void Configure(EntityTypeBuilder<Category> builder)
        {
            builder.HasData(new Category
            {
                Id = Guid.Parse("0828A694-67E0-42E8-BCDB-D6B2428C7C98"),
                Name = "ASP.NET Core",
                CreatedBy = "admin test",
                CreatedDate = DateTime.Now,
                IsDeleted = false
            },
            new Category
            {
                    Id = Guid.Parse("35B37590-FA34-439A-8145-A60DA485905C"),
                    Name = "Visual Studio 2022",
                    CreatedBy = "admin test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
            });


        }
    }
}
