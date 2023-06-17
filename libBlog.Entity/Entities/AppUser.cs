using Blog.Core.Entities;
using Microsoft.AspNetCore.Identity;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBlog.Entity.Entities
{
    public class AppUser : IdentityUser<Guid>, IEntitiesBase
    {
        public string FirstName { get; set; }

        public string LastName { get; set; }

        public Guid ImageId { get; set; } = Guid.Parse("{b458eb43-5af1-4627-3644-08db69ec3847}");

        public Image Image { get; set; }

        public ICollection<Article> Articles { get; set; }

    }
}
