using HotChairsApp.BL;
using HotChairsApp.Model;
using Microsoft.AspNetCore.Mvc;
using Microsoft.Extensions.Logging;
using System;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;

namespace WorkingSpaceManagment.Api.Controllers
{
    [ApiController]
    [Route("[controller]")]
    public class MainController : ControllerBase

    {
        private readonly MainService _service;


        public MainController(MainService service) {
            _service = service;
        }


        private static readonly string[] Summaries = new[]
        {
            "Freezing", "Bracing", "Chilly", "Cool", "Mild", "Warm", "Balmy", "Hot", "Sweltering", "Scorching"
        };

        private readonly ILogger<MainController> _logger;

        //public MainController(ILogger<MainController> logger)
        //{
        //    _logger = logger;
        //}

        //[HttpGet]
        //public async Task<ActionResult> GetAll() {
        //    var rng = new Random();
        //    return Enumerable.Range(1, 5).Select(index => new WeatherForecast
        //    {
        //        Date = DateTime.Now.AddDays(index),
        //        TemperatureC = rng.Next(-20, 55),
        //        Summary = Summaries[rng.Next(Summaries.Length)]
        //    })
        //    .ToArray();

        //    List<Employee> employees = (List<Employee>)await _service.GetAllAsync();
        //    return Ok(employees);
        
    }
}
