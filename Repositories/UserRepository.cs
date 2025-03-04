using Microsoft.EntityFrameworkCore;

using System.Threading.Tasks;
using System.Linq;
using System.Collections.Generic;

using AmadeusG3_Neo_Tech_BackEnd.Models;
using AmadeusG3_Neo_Tech_BackEnd.Data;

// using System.Reflection;

namespace AmadeusG3_Neo_Tech_BackEnd.Repositories{
    
    public class UserRepository{

        //Instancio el contexto para usarlo en el constructor
        private readonly ApplicationDbContext dbContext;

        public UserRepository(ApplicationDbContext dbContext){
            this.dbContext = dbContext;
        }

        public async Task<List<User>> GetAllUsers()
        {
            return await dbContext.Users.ToListAsync();
        }

        public async Task<User?> GetUserById(int id)
        {
            return await dbContext.Users.FirstOrDefaultAsync(user => user.Id == id);
        }

        public async Task<User?> GetUserByEmail(string email)
        {
            return await dbContext.Users.FirstOrDefaultAsync(user => user.Email == email);
        }

        public async Task<User> CreateUser(User user)
        {
            var newUser = dbContext.Users.Add(user);
            await dbContext.SaveChangesAsync();
            return newUser.Entity;
        }

    }
}