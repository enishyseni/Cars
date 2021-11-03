using DataProvider.Contracts;
using DataProvider.Entities;

namespace DataProvider
{
    public interface IUnitOfWork
    {
        IRepository<Car> CarRepository { get; }
        void Commit();
        void Rollback();
    }
}