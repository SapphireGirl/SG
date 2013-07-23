using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using SG.UserBoundedContext;

namespace SG.Repositories
{
    public class User_UnitOfWork : IUnitOfWork<UserContext>
    {
        private readonly UserContext _context;

        public User_UnitOfWork()
        {
            _context = new UserContext();
        }

        public User_UnitOfWork(UserContext context)
        {
            _context = context;
        }
        public UserContext Context
        {
            get { return _context; }
        }

        public int Save()
        {
            return _context.SaveChanges();
        }

        public void Dispose()
        {
            _context.Dispose();
        }
    }
}
