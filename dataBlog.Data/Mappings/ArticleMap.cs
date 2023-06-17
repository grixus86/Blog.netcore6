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
    public class ArticleMap : IEntityTypeConfiguration<Article>
    {
        public void Configure(EntityTypeBuilder<Article> builder)
        {
            builder.HasData(new Article
            {
                Id = Guid.NewGuid(),
                Title = "Asp.net Core Blog VInfo",
                Content = "Asp.net Blog là một nơi để bạn có thể chia sẻ những suy nghĩ, kinh nghiệm, thông tin và cảm xúc của mình với mọi người trên khắp thế giới. Bất kể bạn là một tác giả, nghệ sĩ, doanh nhân hay chỉ là một người đam mê viết lách, blog sẽ giúp bạn truyền tải những thông điệp của mình tới cộng đồng. Thông qua blog, bạn có thể kết nối với những người có cùng sở thích, học hỏi kinh nghiệm từ những người khác và đóng góp vào sự phát triển của cộng đồng trực tuyến.",
                ViewCount = 15,
                CategoryId = Guid.Parse("0828A694-67E0-42E8-BCDB-D6B2428C7C98"),
                ImageId = Guid.Parse("{2064CCB8-BDA9-4800-AD53-5ABA82DD4B06}"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("BA4EC9E4-49E7-4102-A233-E63407D7E3E1")
            },
            new Article
            {
                Id = Guid.NewGuid(),
                Title = "Visual studio Core Blog VInfo",
                Content = "Visual studio Blog là một nơi để bạn có thể chia sẻ những suy nghĩ, kinh nghiệm, thông tin và cảm xúc của mình với mọi người trên khắp thế giới. Bất kể bạn là một tác giả, nghệ sĩ, doanh nhân hay chỉ là một người đam mê viết lách, blog sẽ giúp bạn truyền tải những thông điệp của mình tới cộng đồng. Thông qua blog, bạn có thể kết nối với những người có cùng sở thích, học hỏi kinh nghiệm từ những người khác và đóng góp vào sự phát triển của cộng đồng trực tuyến.",
                ViewCount = 15,
                CategoryId = Guid.Parse("35B37590-FA34-439A-8145-A60DA485905C"),
                ImageId = Guid.Parse("057A756B-6BD4-46B3-898A-96A0A1B26E52"),
                CreatedBy = "Admin Test",
                CreatedDate = DateTime.Now,
                IsDeleted = false,
                UserId = Guid.Parse("390BC994-71D0-4966-A466-AB0B17DAEABC")
            }
            
            
            );
            ;
        }
    }
}
