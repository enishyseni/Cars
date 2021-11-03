using DataProvider;
using DataProvider.Entities;
using DataProvider.Repositories;
using ServiceProvider.Contracts;
using System;
using System.Collections.Generic;
using System.Text;
using System.Threading.Tasks;

namespace ServiceProvider.Services
{
    public class CarService : ICarService
    {
        private readonly IUnitOfWork _db;
        private readonly IEngineService _engineService;
        public CarService(IUnitOfWork unitOfWork, IEngineService engineService)
        {
            _engineService = engineService;
            _db = unitOfWork;
        }

        public Task<Car> Get(long id)
        {
            return _db.CarRepository.GetById(id);
        }

        public async Task<bool> StartEngine(long id)
        {
            //Assuming we get the car from DataProvider
            Car currentCar = await _db.CarRepository.GetById(id);
            return _engineService.Start(currentCar);
        }

        public async Task<Car> UpdateKMsGet(long id)
        {
            Car currentCar = await _db.CarRepository.GetById(id);
            currentCar.KmAmount = currentCar.KmAmount++;
            _db.CarRepository.Save(currentCar);
            return currentCar;
        }

        public Task<IEnumerable<Car>> GetAll()
        {
            return _db.CarRepository.GetAll();
        }

        public bool Save(Car car)
        {
            throw new NotImplementedException();
        }
    }
}
