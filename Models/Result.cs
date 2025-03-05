namespace AmadeusG3_Neo_Tech_BackEnd.Models
{
    public class Result
    {
        public int Id { get; set; }
        public string CityAmerica { get; set; } = string.Empty;
        public string CityEurope { get; set; } = string.Empty;

        //Falta relación de uno a uno con Answer
        public int AnswerId { get; set; }
        public Answer? Answer { get; set; }

        
        
    }
}