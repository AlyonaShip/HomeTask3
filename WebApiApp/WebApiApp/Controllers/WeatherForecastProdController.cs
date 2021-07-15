using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WebApiApp.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastProdController : ControllerBase
    {      

        private readonly ILogger<WeatherForecastProdController> _logger;

        public WeatherForecastProdController(ILogger<WeatherForecastProdController> logger)
        {
            _logger = logger;
        }
              
        [HttpGet]
        public JsonResult Get()
        {
            var msg = "WeatherForecastProdController";
            return new JsonResult(msg);
        }

    }
}
