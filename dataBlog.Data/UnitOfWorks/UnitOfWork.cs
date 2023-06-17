using dataBlog.Data.Context;
using dataBlog.Data.repositories.Abstractions;
using dataBlog.Data.repositories.Concretes;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBlog.Data.UnitOfWorks
{
    public class UnitOfWork : IUnitOfWorks
    {
        private readonly AppDbContext dbContext;

        public UnitOfWork(AppDbContext dbContext)
        {
            this.dbContext = dbContext;
        }
        public async ValueTask DisposeAsync()
        {
            await dbContext.DisposeAsync();
        }

        public int Save()
        {
            return dbContext.SaveChanges();
        }

        public async Task<int> SaveAsync()
        {
            return await dbContext.SaveChangesAsync();
        }

        IRepository<T> IUnitOfWorks.GetRepository<T>()
        {
            return new Repository<T>(dbContext);
        }
    }
}
