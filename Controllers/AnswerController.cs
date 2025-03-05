using AmadeusG3_Neo_Tech_BackEnd.Data;
using Microsoft.AspNetCore.Mvc;
using AmadeusG3_Neo_Tech_BackEnd.Services;
using AmadeusG3_Neo_Tech_BackEnd.Models;
using AmadeusG3_Neo_Tech_BackEnd.Dtos.Request;
using AmadeusG3_Neo_Tech_BackEnd.Dtos.Response;
namespace AmadeusG3_Neo_Tech_BackEnd.Controllers
{
    [Route("api/[controller]")]
    [ApiController]
    public class AnswerController : ControllerBase
    {
        private readonly AnswerService answerService;
        private readonly CalculateDestinyService calculateDestinyService;

        public AnswerController(ApplicationDbContext dbContext)
        {
            answerService = new AnswerService(dbContext);
            calculateDestinyService = new CalculateDestinyService(dbContext);
        }

        // [HttpPost]
        // public async Task<IActionResult> CreateAnswer(Answer answer)
        // {
        //     var newAnswer = await answerService.CreateAnswer(answer);
        //     return Created(nameof(CreateAnswer), newAnswer);
        // }

        [HttpPost]
        public async Task<IActionResult> CalculateDestiny(DestinationRequest destinationRequest)
        {
            try{
                DestinationResponse destinationResponse = await Task.Run(() => calculateDestinyService.CalculateDestiny(destinationRequest));
                return Ok(destinationResponse);

            } catch{

                return BadRequest("Error al calcular el destino");

            }
        }
    }
}