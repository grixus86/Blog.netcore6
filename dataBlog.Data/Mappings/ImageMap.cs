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
    public class ImageMap : IEntityTypeConfiguration<Image>
    {
        public void Configure(EntityTypeBuilder<Image> builder)
        {
            builder.HasData(new Image
            {
                    Id = Guid.Parse("{2064CCB8-BDA9-4800-AD53-5ABA82DD4B06}"),
                    FileName = "images/testimage",
                    FileType = "jpg",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false

            },
            new Image
            {
                    Id = Guid.Parse("057A756B-6BD4-46B3-898A-96A0A1B26E52"),
                    FileName = "images/vstest",
                    FileType = "png",
                    CreatedBy = "Admin Test",
                    CreatedDate = DateTime.Now,
                    IsDeleted = false
            }
            );
        }
    }
}
