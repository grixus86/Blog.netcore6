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
    public class UserRoleMap : IEntityTypeConfiguration<AppUserRole>
    {
        public void Configure(EntityTypeBuilder<AppUserRole> builder)
        {
            builder.HasKey(r => new { r.UserId, r.RoleId });

            // Maps to the AspNetUserRoles table
            builder.ToTable("AspNetUserRoles");

            builder.HasData(new AppUserRole
            {
                UserId = Guid.Parse("BA4EC9E4-49E7-4102-A233-E63407D7E3E1"),
                RoleId = Guid.Parse("AFFC7CF6-7CED-4DDA-A558-FE1468F829CA")
            },
            new AppUserRole
            {
                UserId = Guid.Parse("390BC994-71D0-4966-A466-AB0B17DAEABC"),
                RoleId = Guid.Parse("96CC55AA-788C-421D-B610-BC3489D13F52")
            });
        }
    }
}
