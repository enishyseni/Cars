using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using DataProvider.Entities;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using ServiceProvider.Contracts;

namespace AgicapCars.Controllers
{
    [ApiController]
    [Route("api/[controller]")]
    public class CarController : ControllerBase
    {
        private readonly ILogger<CarController> _logger;
        private readonly ICarService _carService;

        public CarController(ILogger<CarController> logger, ICarService carService)
        {
            _logger = logger;
            _carService = carService;
        }

        [HttpGet("get")]
        public async Task<Car> Get([FromRoute] long id)
        {
            return await _carService.Get(id);
        }

        [HttpGet("startengine/{id:long}")]
        public async Task<bool> StartEngine([FromRoute] long id)
        {
            return await _carService.StartEngine(id);
        }

        [HttpGet("updatekms/{id:long}")]
        public async Task<Car> UpdateKMsAsync([FromRoute] long id)
        {
            return await _carService.UpdateKMsGet(id);
        }

        [HttpGet("getall")]
        public async Task<Car> GetAll([FromRoute] long id)
        {
            return await _carService.Get(id);
        }
    }
}
