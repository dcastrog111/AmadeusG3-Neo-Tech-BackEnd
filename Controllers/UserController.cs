using AmadeusG3_Neo_Tech_BackEnd.Data;
using Microsoft.AspNetCore.Mvc;
using AmadeusG3_Neo_Tech_BackEnd.Services;
using AmadeusG3_Neo_Tech_BackEnd.Models;

namespace AmadeusG3_Neo_Tech_BackEnd.Controllers{

    [Route("api/[controller]")]
    [ApiController]

    public class UserController : ControllerBase{

        private readonly UserService userService;

        public UserController(ApplicationDbContext dbContext){
            userService = new UserService(dbContext);
        }

        [HttpGet]
        public async Task<IActionResult> GetAllUsers()
        {
            var users = await userService.GetAllUsers();
            return Ok(users);
        }

        [HttpGet("{id}")]
        public async Task<IActionResult> GetUserById(int id)
        {
            var user = await userService.GetUserById(id);
            if(user == null){
                return NotFound();
            }
            return Ok(user);
        }

        [HttpPost]
        public async Task<IActionResult> CreateUser(User user)
        {
            var newUser = await userService.CreateUser(user);
            return Created(nameof(GetUserById), newUser);
        }

    }

}