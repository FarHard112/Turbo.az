using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using TurboAZ.DAL.Repository.Abstract;

namespace TurboAZ.DAL.Repository.Concrete
{
    public class Repository<TEntity> : IRepository<TEntity> where TEntity : class
    {
        private readonly TurboDBContext _context;
        private readonly DbSet<TEntity> _dbSet;

        public Repository(TurboDBContext context, DbSet<TEntity> dbSet)
        {
            _context = context;
            _dbSet = dbSet;
        }

        public void Add(TEntity entity)
        {
            _dbSet.Add(entity);
        }

        public IEnumerable<TEntity> GetAll()
        {
            return _dbSet.ToList();
        }

        public TEntity GetById(int id)
        {
            return _dbSet.Find(id);
        }

        public void Remove(int id)
        {
            _dbSet.Remove(GetById(id));
        }
    }
}