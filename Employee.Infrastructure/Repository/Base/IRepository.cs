using Employee.Shared.Model;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace Employee.Infrastructure.Repository.Base
{
    public interface IRepository<T>
    {
        Task<bool> Any();
         Task<List<T>> GetAll();
         Task<List<T>> GetAll(Expression<Func<T,bool>> expression);
        Task<List<T>> GetAll(int count, int skip);
        Task<T> GetOne(Expression<Func<T,bool>> expression);

    }
}
