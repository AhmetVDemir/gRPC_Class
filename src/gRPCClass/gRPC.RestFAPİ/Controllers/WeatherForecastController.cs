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
        [HttpPost]
        public IActionResult GetTest(TaskDTO taskDTO) {
            var x = taskDTO;
            var c = _taskService.Add(new Entity.Concrete.DTOs.TaskDTO());
            return Ok("Tamamdır");
        }

       
    }

    public class TestModel
    {
        public string TaskName { get; set; }

        public string Description { get; set; }

        public string StartTime { get; set; }

        public string TerminTime { get; set; }

        public string Proggress { get; set; }

        public string AsignTo { get; set; }

    }


 
}