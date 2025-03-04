namespace AmadeusG3_Neo_Tech_BackEnd.Models{

    public class Answer
    {
        //Falta anotador para que sea id autoincremental
        public int Id { get; set; }
        public string Destiny { get; set; } = string.Empty;
        public string Weather { get; set; } = string.Empty;
        public string Activity { get; set; } = string.Empty;
        public string Housing { get; set; } = string.Empty;
        public string TravelTime { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;

        public DateTime RegistDate { get; set; } = DateTime.UtcNow;

        //relación de 1 a muchos con user
        public int? UserId { get; set; }

        public User? User { get; set; }
    
        
    }
}