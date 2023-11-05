using gRPC.Business.Absrtract;
using gRPC.Entity.Concrete.DTOs;
using Microsoft.AspNetCore.Mvc;
using System.Diagnostics;

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
        public IActionResult GetTest()
        {
            var timezones = TimeZoneInfo.GetSystemTimeZones();

            var outlet2 = new Dictionary<double, List<string>>();

            timezones.ToList().ForEach(tz =>
            {
                double utcOffsetMinutes = tz.GetUtcOffset(DateTime.Now).TotalMinutes;
                string displayName = tz.DisplayName;

                if (outlet2.ContainsKey(utcOffsetMinutes))
                {
                    // Eğer anahtar (UTC ofseti) zaten varsa, ilgili listeye yeni bir zaman dilimi adı ekleyin.
                    outlet2[utcOffsetMinutes].Add(displayName);
                }
                else
                {
                    // Eğer anahtar (UTC ofseti) daha önce eklenmemişse, yeni bir liste oluşturun ve zaman dilimi adını ekleyin.
                    var displayNameList = new List<string> { displayName };
                    outlet2.Add(utcOffsetMinutes, displayNameList);
                }
            });

            return Ok(outlet2);


        }

        [Route("/test2")]
        [HttpGet]
        public IActionResult GetTest2()
        {
            int i = 0;



            return Ok("z");
        }
    }


    
    public class TimeZoneInfoDto
    {
        public string Id { get; set; }
        public string StandardName { get; set; }
        public string DaylightName { get; set; }
        public TimeSpan BaseUtcOffset { get; set; }
        public bool SupportsDaylightSavingTime { get; set; }
    }


}