using Core.Models.ResultModels;
using Core.Services;
using Microsoft.AspNetCore.Mvc;

namespace NUnitForMockUnitTestAndIntegrationTest.Controllers
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
        private readonly IContractService _contractService;


        public WeatherForecastController(
            ILogger<WeatherForecastController> logger,
            IContractService contractService
            )
        {
            _logger = logger;
            _contractService = contractService;
        }

        [HttpGet(Name = "GetWeatherForecast")]
        public async Task<int> Get(int id)
        {
            var rs = await _contractService.GetById(id);
            return (int)rs.Data;
        }

        //public IEnumerable<WeatherForecast> Get2()
        //{
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateOnly.FromDateTime(DateTime.Now.AddDays(index)),
        //        TemperatureC = Random.Shared.Next(-20, 55),
        //        Summary = Summaries[Random.Shared.Next(Summaries.Length)]
        //    })
        //    .ToArray();

        //}

        //[HttpGet(Name = "GetById")]
        //public async Task<int> GetById(int id)
        //{
        //    var rs = await _contractService.GetById(id);
        //    return (int)rs.Data;
        //}
    }
}
