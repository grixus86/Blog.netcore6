using Blog.Service.Services.Abstractions;
using dataBlog.Data.UnitOfWorks;
using libBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace Blog.Service.Services.Concrete
{
    public class DashboardService : IDashboardService
    {
        private readonly IUnitOfWorks unitOfWorks;

        public DashboardService(IUnitOfWorks unitOfWorks)
        {
            this.unitOfWorks = unitOfWorks;
        }

        public async Task<List<int>> GetYearlyArticleCounts()
        {
            var articles = await unitOfWorks.GetRepository<Article>().GetAllAsync(x => !x.IsDeleted);

            var startDate = DateTime.Now.Date;
            startDate = new DateTime(startDate.Year, 1, 1);

            List<int> datas = new();
            for(int i = 1; i <= 12; i++)
            {
                var startedDate = new DateTime(startDate.Year, i, 1);
                var endedDate = startedDate.AddMonths(1);
                var data = articles.Where(x => x.CreatedDate >= startedDate && x.CreatedDate < endedDate).Count();
                datas.Add(data);
            }
            return datas;
        }
        public async Task<int> GetTotalArticleCount()
        {
            var articleCount = await unitOfWorks.GetRepository<Article>().CountAsync();
            return articleCount;
        }
        public async Task<int> GetTotalCategoryCount()
        {
            var categoryCount = await unitOfWorks.GetRepository<Category>().CountAsync();
            return categoryCount;
        }

    }
}
