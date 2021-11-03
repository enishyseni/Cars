using DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProvider.Contracts
{
    public interface ICarService
    {
        bool Save(Car car);
        Task<Car> Get(long id);
        Task<bool> StartEngine(long id);
        Task<Car> UpdateKMsGet(long id);
        Task<IEnumerable<Car>> GetAll();
    }
}
