using Blog.Core.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using libBlog.Entities;

namespace libBlog.Entity.Entities  
{
    public class Article : EntitiesBase
    {
        public Article()
        {

        }
        public Article(string title,string content,Guid userId, string createBy, Guid categoryId, Guid imageId)
        {
            Title = title;
            Content = content;
            UserId = userId;
            CategoryId = categoryId;
            ImageId = imageId;
            CreatedBy = createBy;

        }
        public string Title { get; set; }
        public string Content { get; set; }
        public int ViewCount { get; set; } = 0;

        public Guid CategoryId { get; set; }
        public Category Category { get; set; }

        public Guid? ImageId { get; set; }
        public Image Image { get; set; }

        public Guid UserId { get; set; }

        public AppUser User { get; set; }
        public ICollection<ArticleVisitor> ArticleVisitors { get; set; }


    }
}
