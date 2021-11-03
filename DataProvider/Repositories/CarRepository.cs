using DataProvider.Contracts;
using DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Text;
using System.Threading.Tasks;

namespace DataProvider.Repositories
{
    public class CarRepository : IRepository<Car>
    {
        private readonly DbContext dbContext;

        public CarRepository(DbContext context)
        {
            dbContext = context;
        }

        public bool Save(Car car)
        {
            return true;
        }

        public async Task<Car> GetById(long id)
        {
            return new Car();
        }

        public async Task<IEnumerable<Car>> GetAll()
        {
            return Enumerable.Empty<Car>();
        }
    }
}
