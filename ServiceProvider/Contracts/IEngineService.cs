using DataProvider.Entities;
using System;
using System.Collections.Generic;
using System.Text;

namespace ServiceProvider.Contracts
{
    public interface IEngineService
    {
        bool Start(Car car);
    }
}
