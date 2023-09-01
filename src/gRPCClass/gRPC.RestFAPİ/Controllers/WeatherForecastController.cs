using gRPC.Business.Absrtract;
using gRPC.Entity.Concrete.DTOs;
using Microsoft.AspNetCore.Mvc;

namespace gRPC.RestFAPİ.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class WeatherForecastController : ControllerBase
    {
        private static readonly string[] Summaries = new[]
        {
        "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
    };

        private readonly ILogger<WeatherForecastController> _logger;
        private readonly ITaskService _taskService;

        public WeatherForecastController(ILogger<WeatherForecastController> logger, ITaskService taskService)
        {
            _logger = logger;
            _taskService = taskService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public IEnumerable<WeatherForecast> Get()
        {
            return Enumerable.Range(1, 5).Select(index => new WeatherForecast
            {
                Date = DateTime.Now.AddDays(index),
                TemperatureC = Random.Shared.Next(-20, 55),
                Summary = Summaries[Random.Shared.Next(Summaries.Length)]
            })
            .ToArray();
        }
        [Route("/gettest")]
        [HttpGet]
        public string GetTest(TaskDTO taskDTO) {
            var c = _taskService.Add(new Entity.Concrete.DTOs.TaskDTO());
            return "Tamamdır";
        }

       
    }


 
}