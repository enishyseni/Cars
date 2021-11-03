using DataProvider.Contracts;
using DataProvider.Entities;
using DataProvider.Repositories;
using System;
using System.Collections.Generic;
using System.Text;

namespace DataProvider
{
    public class UnitOfWork : IUnitOfWork
    {
        private readonly DbContext _dbContext;

        private IRepository<Car> _carRepository;

        public UnitOfWork(DbContext context)
        {
            _dbContext = context;
        }

        public IRepository<Car> CarRepository
        {
            get
            {
                return _carRepository = _carRepository ?? new CarRepository(_dbContext);
            }
        }

        public void Commit()
        {
            _dbContext.SaveChanges();
        }

        public void Rollback()
        {
            _dbContext.Dispose();
        }
    }
}
