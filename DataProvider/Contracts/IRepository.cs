using DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Contracts
{
    public interface IRepository<TEntity> where TEntity : class
    {
        bool Save(Car car);
        Task<TEntity> GetById(long id);
        Task<IEnumerable<TEntity>> GetAll();
    }
}
