using AmadeusG3_Neo_Tech_BackEnd.Models;
using AmadeusG3_Neo_Tech_BackEnd.Data;
using AmadeusG3_Neo_Tech_BackEnd.Repositories;


namespace AmadeusG3_Neo_Tech_BackEnd.Services{

    public class AnswerService{

        private readonly AnswerRepository answerRepository;

        public AnswerService(ApplicationDbContext dbContext){
            
            answerRepository = new AnswerRepository(dbContext);
        }

        public async Task<Answer> CreateAnswer (Answer answer)
        {
            return await answerRepository.CreateAnswer(answer);
        }

    }
}