using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace libBlog.Entity.Entities
{
    public class Category : EntitiesBase
    {

        public Category()
        {

        }
        public Category(string name, string createBy)
        {
            Name = name;
            CreatedBy = createBy;
        }
        public Guid Id { get; set; }
        public string Name { get; set; }
        public ICollection<Article> Article { get; set; }


    }
}
