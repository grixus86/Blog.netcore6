using Blog.Core.Entities;
using dataBlog.Data.repositories.Abstractions;
using libBlog.Entity.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace dataBlog.Data.UnitOfWorks
{
    public interface IUnitOfWorks : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class, IEntitiesBase, new();

        Task<int> SaveAsync();
        int Save();
    }}
