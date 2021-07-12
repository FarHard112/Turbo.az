using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace TurboAZ.DAL.Repository.Abstract
{
    public interface IRepository<TEntity> where TEntity:class
    {

        TEntity GetById(int id);
        IEnumerable<TEntity> GetAll();
        void Add(TEntity entity);
        void Remove(int id);
    }
}