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
    public class TagManager : IService<Tag>
    {
        GenericRepository<Tag> _tag = new GenericRepository<Tag>();
        public void Add(Tag p)
        {
            _tag.Insert(p); 
        }

        public void Delete(Tag p)
        {
            _tag.Delete(p);
        }

        public Tag GetById(int id)
        {
            return _tag.Get(x => x.Id == id);
        }

        public List<Tag> List()
        {
            return _tag.List();
        }

        public List<Tag> List(Expression<Func<Tag, bool>> filter)
        {
            return _tag.List(filter);
        }

        public void Update(Tag p)
        {
            _tag.Update(p); 
        }
    }
}
