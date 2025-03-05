using AmadeusG3_Neo_Tech_BackEnd.Data;
using Microsoft.AspNetCore.Mvc;
using AmadeusG3_Neo_Tech_BackEnd.Services;
using AmadeusG3_Neo_Tech_BackEnd.Models;

namespace AmadeusG3_Neo_Tech_BackEnd.Controllers{

    [Route("api/[controller]")]
    [ApiController]
    public class CityController : ControllerBase{

        private readonly CityService cityService;
        
        public CityController(ApplicationDbContext dbContext){

            cityService = new CityService(dbContext);
        }

        [HttpGet("{DestinoA}/{DestinoE}")]
        public async Task<IActionResult> GetCityByName(string DestinoA, string DestinoE)
        {
            List<City> cities = new List<City>();

            var cityA = await cityService.GetCityByName(DestinoA);
            var cityE = await cityService.GetCityByName(DestinoE);
            
            if (cityA != null && cityE != null)
            {
                cities.Add(cityA);
                cities.Add(cityE);
            }

            return Ok(cities);
        }
    }
}