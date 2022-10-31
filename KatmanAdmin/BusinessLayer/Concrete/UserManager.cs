using FluentValidation.Results;
using KatmanAdmin.BusinessLayer.Abstract;
using KatmanAdmin.DataAccess.Concrete;
using KatmanAdmin.DataAccess.Concrete.Repositories;
using KatmanAdmin.Entity.Entities;

using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace KatmanAdmin.BusinessLayer.Concrete
{
    public class UserManager:IService<User>
    {
        private readonly Context _context;
        GenericRepository<User> _user = new GenericRepository<User>();
        public UserManager()
        {
            _context = new Context();   
        }

        public bool Login(string email, string password)
        {
            var result = _context.Users.FirstOrDefault(u => u.Email == email && u.Password == password);

            if (result == null)
            {
                return false;
            }
            else
            {
                return true;
            }
        }

        public void Add(User p)
        {
            _user.Insert(p);
        }

        public void Delete(User p)
        {
            _user.Delete(p);    
        }

        public void Update(User p)
        {
            _user.Update(p);
        }

        public List<User> List()
        {
            return _user.List();   
        }

        public List<User> List(Expression<Func<User, bool>> filter)
        {
            return _user.List(filter);
        }

        public User GetById(int id)
        {
            return _user.Get(x => x.Id == id);
        }
    }
}
