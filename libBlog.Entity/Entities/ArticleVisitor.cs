using Blog.Core.Entities;
using libBlog.Entities;
using libBlog.Entity.Entities;

namespace libBlog.Entities
{
    public class ArticleVisitor : IEntitiesBase
    {
        public ArticleVisitor() { }

        public ArticleVisitor(Guid articleId,int visitorId)
        {
            ArticleId = articleId;
            VisitorId = visitorId;
        }

        public Guid ArticleId { get; set; }
        public Article Article { get; set; }
        public int VisitorId { get; set; }
        public Visitor Visitor { get; set; }
    }
}
