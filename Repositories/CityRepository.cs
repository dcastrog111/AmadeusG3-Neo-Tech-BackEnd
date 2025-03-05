using AmadeusG3_Neo_Tech_BackEnd.Models;
using AmadeusG3_Neo_Tech_BackEnd.Data;
using Microsoft.EntityFrameworkCore;
using System.Threading.Tasks;

namespace AmadeusG3_Neo_Tech_BackEnd.Repositories{

    public class CityRepository{
        
        private readonly ApplicationDbContext dbContext;

        public CityRepository(ApplicationDbContext dbContext){
            this.dbContext = dbContext;
        }

        public async Task<City?> GetCityByName(string NombreDestino)
        {
            return await dbContext.Cities.FirstOrDefaultAsync(city => city.NombreDestino == NombreDestino);
        }

    }
}