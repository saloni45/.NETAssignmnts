using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;

namespace Employee_App.Models
{
    public interface IRepository<T> : IDisposable where T : class
    {
        T Add(T item);
        T Update(T item);
        T Delete(T item);
        Task<int> Commit();
        Task<IEnumerable<T>> Get(Expression<Func<T, bool>> condition = null, string includes = null);

    }
}
