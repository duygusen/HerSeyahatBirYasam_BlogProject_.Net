using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using Project.Core.Entities;
using Project.Data.Repositories.Abstractions;
using Project.Entity.Entities;

namespace Project.Data.UnitOfWorks
{
    public interface IUnitOfWork : IAsyncDisposable
    {
        IRepository<T> GetRepository<T>() where T : class,IEntityBase, new();
        Task<int> SaveAsync();
        int Save();
    }
}
