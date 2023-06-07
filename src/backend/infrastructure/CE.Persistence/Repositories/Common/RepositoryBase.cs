using CE.Application.Common;
using CE.Persistence.Context;
using Microsoft.EntityFrameworkCore;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Linq.Expressions;
using System.Text;
using System.Threading.Tasks;

namespace CE.Persistence.Repositories.Common
{
    public abstract class RepositoryBase<T> : IRepositoryBase<T> where T : class
    {
        private readonly RepositoryContext _context;

        public RepositoryBase(RepositoryContext context)
        {
            _context = context;
        }
        public void Add(T entity)
        {
            _context.Set<T>().Add(entity);
        }

        public void Delete(T entity)
        {
            _context.Set<T>().Remove(entity);
        }

        public async Task<ICollection<T>> FindAllAsync(bool trackChanges)
        {
            return trackChanges ? await _context.Set<T>().ToListAsync():
                                  await _context.Set<T>().AsNoTracking().ToListAsync();

        }

        public async Task<ICollection<T>> FindByConditionAsync(Expression<Func<T, bool>> expression, bool trackChanges)
        {
            return trackChanges ? await _context.Set<T>().Where(expression).ToListAsync():
                                  await _context.Set<T>().AsNoTracking().Where(expression).ToListAsync();
        } 

        public void Update(T entity)
        {
            _context.Set<T>().Update(entity);
        }
    }
}
