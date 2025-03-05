namespace AmadeusG3_Neo_Tech_BackEnd.Models
{
    public class User
    {
        public int Id { get; set; }
        public string Name { get; set; } = string.Empty;
        public string Email { get; set; } = string.Empty;

        //public List<Answer> Answers { get; set; } = new List<Answer>();
    }
}