using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Threading.Tasks;

namespace MyPortfolio.Repository.Abstract
{
    public interface IGenerallyInterfaceRepository<T> where T :class
    {
        T GetById(int Id);
        IQueryable<T> GetAll();
        IQueryable<T> Find(Expression<Func<T, bool>>predicate);

        void Add(T entity);
        void Delete(T entity);
        void Edit(T entity);
        void Save();

        

    }
}
