using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace ManpreetBooks.DataAccess.Repository.IRepository
{
    public interface IRepository<T> where T:class
    {
        T Get(int id);
        IEnumerable<T> GetAll(
          Expression<Func<T, bool>> filter = null,
          Func<IQueryable<T>, IOrderedQueryable<T>> odereBy = null,
          string includeProperties = null

            );

        T GetFirstOrDefault(
           Expression<Func<T, bool>> filter = null,
          Func<IQueryable<T>, IOrderedQueryable<T>> odereBy = null,
          string includeProperties = null

            );
        void Add(T entity); //add entity

        void Remove(int id);//to remove an object and category

        void Remove(T entity); // another way to remove an object

        void RemoveRange(IEnumerable<T> entity);// remove acomplete range of attributes
    }
}
