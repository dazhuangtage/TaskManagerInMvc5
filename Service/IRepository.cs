using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;
using System.Data.Entity;
namespace Service
{
    public interface IRepository<T> where T:Domain.EntityBase
    {
        DbContext Context { get; }
        Domain.MyConfig MyConfig { get; }

        DbSet<T> DbSet { get; }

        DbContextTransaction DbContextTransation { get; }

        bool Commmit { get; set; }

        void Commit();

        void Rollback();
    }
}
