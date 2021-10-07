using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using System.Linq.Expressions;
using Microsoft.EntityFrameworkCore;

namespace Employee_App.Models
{
    public class GenericRepository<T> : IRepository<T> where T : class
    {
        private readonly CompanyContext companyContext;

        public GenericRepository(CompanyContext companyContext)
        {
            this.companyContext = companyContext;
        }

        public T Add(T item)
        {
            return companyContext.Add(item).Entity;
        }

        public T Update(T item)
        {
            return companyContext.Update(item).Entity;
        }

        public T Delete(T item)
        {
            return companyContext.Remove(item).Entity;
        }

        public void Dispose()
        {
            companyContext.Dispose();
        }

        public async Task<IEnumerable<T>> Get(Expression<Func<T, bool>> condition = null, string includes = null)
        {
            var Set = companyContext.Set<T>().AsQueryable();
            if (includes != null)
            {
                var NavigationProperties = includes.Split(',');
                foreach (var NavigationProperty in NavigationProperties)
                {
                    Set = Set.Include(NavigationProperty);
                }
            }
                if (condition != null)
                {
                    Set = Set.Where(condition);
                }
                return await Set.ToListAsync();
            
        }

        public async Task<int> Commit()
        {
            return await companyContext.SaveChangesAsync();
        }

       
    }
}
