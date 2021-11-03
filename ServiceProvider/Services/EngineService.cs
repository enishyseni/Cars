using DataProvider.Entities;
using ServiceProvider.Contracts;
using System;

namespace ServiceProvider.Services
{
    public class EngineService : IEngineService
    {
        public bool Start(Car car)
        {
            return true;
        }
    }
}
