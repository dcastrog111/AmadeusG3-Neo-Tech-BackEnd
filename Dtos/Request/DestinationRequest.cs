namespace AmadeusG3_Neo_Tech_BackEnd.Dtos.Request
{
    public class DestinationRequest
    {
        public string Destiny { get; set; } = string.Empty;
        public string Weather { get; set; } = string.Empty;
        public string Activity { get; set; } = string.Empty;
        public string Housing { get; set; } = string.Empty;
        public string TravelTime { get; set; } = string.Empty;
        public string Age { get; set; } = string.Empty;
        public int? UserId { get; set; }
    }
}