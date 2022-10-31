using FluentValidation.Results;
using KatmanAdmin.BusinessLayer.Abstract;

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
    public class CategoryManager : IService<Category>
    {
        GenericRepository<Category> _category = new GenericRepository<Category>();

        public void Add(Category p)
        {
            _category.Insert(p);
        }

        public void Delete(Category p)
        {
            _category.Delete(p);
        }

        public Category GetById(int id)
        {
            return _category.Get(x => x.Id == id);
        }

        public List<Category> List()
        {
            return _category.List();
        }

        public List<Category> List(Expression<Func<Category, bool>> filter)
        {
            return _category.List(filter);
        }

        public void Update(Category p)
        {
            _category.Update(p);    
        }        
    }
}
