using AmadeusG3_Neo_Tech_BackEnd.Models;
using AmadeusG3_Neo_Tech_BackEnd.Data;
using AmadeusG3_Neo_Tech_BackEnd.Repositories;

namespace AmadeusG3_Neo_Tech_BackEnd.Services{

    public class CityService{

        private readonly CityRepository cityRepository;

        public CityService(ApplicationDbContext dbContext){
            
            cityRepository = new CityRepository(dbContext);
        }

        public async Task<City?> GetCityByName(string NombreDestino)
        {
            return await cityRepository.GetCityByName(NombreDestino);
        }

    }
}