using Microsoft.EntityFrameworkCore;
using AmadeusG3_Neo_Tech_BackEnd.Models;

namespace AmadeusG3_Neo_Tech_BackEnd.Data{
    public class ApplicationDbContext: DbContext{

        public ApplicationDbContext(DbContextOptions<ApplicationDbContext> options): base(options){

        }

        //Falta DbSet de los modelos
        public DbSet<User> Users { get; set; }
        public DbSet<Answer> Answers { get; set; }
        public DbSet<City> Cities { get; set; }
        public DbSet<Result> Results { get; set; }
        
    }
}