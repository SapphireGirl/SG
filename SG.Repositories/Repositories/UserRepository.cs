using System;
using System.Collections.Generic;
using System.Data;
using System.Data.Entity;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using SG.UserBoundedContext;
using SG.Model;

namespace SG.Repositories
{
    public class UserRepository : IUserRepository
    {
        private readonly UserContext  _context;

        public UserRepository(User_UnitOfWork uow)
        {
            _context = uow.Context;
        }

        public IQueryable<User> All
        {
            get { return _context.Users; }
        }

        public IQueryable<User> AllIncluding(params Expression<Func<User, object>>[] includeProperties)
        {
            IQueryable<User> query = _context.Users;
            foreach (var includeProperty in includeProperties)
            {
                query = query.Include(includeProperty);
            }
            return query;
        }

        public User Find(int id)
        {
            return _context.Users.Find(id);
        }

        public void InsertOrUpdate(User user)
        {
            if (user.UserId == default(int)) // A new entity
            {
                _context.Entry(user).State = EntityState.Added;
            }
            else
            {
                _context.Entry(user).State = EntityState.Modified;
            }
        }

        public void Delete(int id)
        {
            var user = _context.Users.Find(id);
            _context.Users.Remove(user);
        }

        public void Dispose()
        {
            _context.Dispose();
            
        }

        // Separate Methods

        public List<User> AllUsers
        {
            get { return _context.Users.ToList(); }
        }

        //public List<User> AllUsersWhoHaveWishes
        //{
        //    // TODO
        //    get { return _context.Users.Where(u => u.PersonalInfo.Any()); }
        //}
    }
}
