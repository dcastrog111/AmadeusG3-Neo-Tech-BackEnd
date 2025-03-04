using AmadeusG3_Neo_Tech_BackEnd.Data;
using AmadeusG3_Neo_Tech_BackEnd.Models;

namespace AmadeusG3_Neo_Tech_BackEnd.Repositories{
    public class ResultRepository{

        //Instancio el contexto para usarlo en el constructor
        private readonly ApplicationDbContext dbContext;

        public ResultRepository(ApplicationDbContext dbContext){
            this.dbContext = dbContext;
        }

        public async Task<Result> CreateResult(Result result)
        {
            var newResult = dbContext.Results.Add(result);
            await dbContext.SaveChangesAsync();
            return newResult.Entity;
        }
    }
}