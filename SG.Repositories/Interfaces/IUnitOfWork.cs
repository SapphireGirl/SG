using System;
using System.Collections.Generic;
using System.Data.Entity;
using System.Linq;
using System.Text;

namespace SG.Repositories
{
    public interface IUnitOfWork<TContext> : IDisposable where TContext : DbContext
    {
        
        TContext Context { get;  }
        int Save();
    }
}
