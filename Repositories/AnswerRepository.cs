using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

using AmadeusG3_Neo_Tech_BackEnd.Models;
using AmadeusG3_Neo_Tech_BackEnd.Data;

// using System.Reflection;

namespace AmadeusG3_Neo_Tech_BackEnd.Repositories{
    
    public class AnswerRepository{

        //Instancio el contexto para usarlo en el constructor
        private readonly ApplicationDbContext dbContext;

        public AnswerRepository(ApplicationDbContext dbContext){
            this.dbContext = dbContext;
        }

        public async Task<Answer> CreateAnswer(Answer answer)
        {
            var newAnswer = dbContext.Answers.Add(answer);
            await dbContext.SaveChangesAsync();
            return newAnswer.Entity;
        }

    }
}