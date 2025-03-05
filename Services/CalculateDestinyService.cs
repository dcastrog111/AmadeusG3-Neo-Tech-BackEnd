using AmadeusG3_Neo_Tech_BackEnd.Dtos.Request;
using AmadeusG3_Neo_Tech_BackEnd.Dtos.Response;
using AmadeusG3_Neo_Tech_BackEnd.Models;
using AmadeusG3_Neo_Tech_BackEnd.Data;
using AmadeusG3_Neo_Tech_BackEnd.Repositories;

namespace AmadeusG3_Neo_Tech_BackEnd.Services{

    public class CalculateDestinyService
    {

        private readonly AnswerRepository answerRepository;
        private readonly UserRepository userRepository;
        private readonly ResultRepository resultRepository;

        public CalculateDestinyService(ApplicationDbContext dbContext){
            
            answerRepository = new AnswerRepository(dbContext);
            userRepository = new UserRepository(dbContext);
            resultRepository = new ResultRepository(dbContext);
        }

        String Destino = "";
        String Climatica = "";
        String Viaje = "";
        String Edad = "";
        String Actividad = "";
        String Alojamiento = "";
        String DestinoA = "";
        String DestinoE = "";

        public async Task<DestinationResponse> CalculateDestiny(DestinationRequest destinationRequest)
        {
            Destino = destinationRequest.Destiny;
            Climatica = destinationRequest.Weather;
            Viaje = destinationRequest.TravelTime;
            Edad = destinationRequest.Age;
            Actividad = destinationRequest.Activity;
            Alojamiento = destinationRequest.Housing;

            Dictionary<string, string[]> destinos = new Dictionary<string, string[]>();

            destinos.Add("Playa-Caluroso-1-2 semanas-Menos de 30 años-Deportes y Aventuras-Hostal o Albergue", new String[]{"Tulum", "Ibiza"});
            destinos.Add("Playa-Caluroso-1-2 semanas-Menos de 30 años-Relax y Bienestar-Hotel de Lujo", new String[]{"Playa del Carmen", "Santori"});
            destinos.Add("Playa-Caluroso-1-2 semanas-30-50 años-Cultura y Museos-Hotel de Lujo", new String[]{"Honolulu", "Malta"});
            destinos.Add("Playa-Caluroso-Menos de una semana-Menos de 30 años-Cultura y Museos-Airbnb", new String[]{"Cartagena", "Barcelona"});
            destinos.Add("Playa-Templado-1-2 semanas-Menos de 30 años-Cultura y Museos-Hostal o Albergue", new String[]{"San Juan", "Niza"});
            destinos.Add("Playa-Templado-1-2 semanas-30-50 años-Cultura y Museos-Hotel de Lujo", new String[]{"Río de Janeiro", "Lisboa"});
            destinos.Add("Playa-Templado-Más de dos semanas-Más de 50 años-Relax y Bienestar-Airbnb", new String[]{"Punta Cana", "Algarve"});
            destinos.Add("Montaña-Frío-1-2 semanas-Más de 50 años-Cultura y Museos-Airbnb", new String[]{"Ushuaia", "Reykjavik"});
            destinos.Add("Montaña-Frío-1-2 semanas-Más de 50 años-Relax y Bienestar-Airbnb", new String[]{"Aspen", "Innsbruck"});
            destinos.Add("Montaña-Frío-1-2 semanas-Menos de 30 años-Deportes y Aventuras-Hostal o Albergue", new String[]{"Bariloche", "Interlaken"});
            destinos.Add("Montaña-Frío-1-2 semanas-30-50 años-Deportes y Aventuras-Hotel de Lujo", new String[]{"Banff", "Zermatt"});
            destinos.Add("Montaña-Templado-1-2 semanas-Más de 50 años-Cultura y Museos-Airbnb", new String[]{"Cusco", "Granada"});
            destinos.Add("Montaña-Templado-Más de dos semanas-Menos de 30 años-Deportes y Aventuras-Airbnb", new String[]{"Machu Picchu", "Chamonix"});
            destinos.Add("Ciudad-Caluroso-1-2 semanas-Más de 50 años-Cultura y Museos-Hotel de Lujo", new String[]{"Los Angeles", "Roma"});
            destinos.Add("Ciudad-Frío-1-2 semanas-30-50 años-Cultura y Museos-Hotel de Lujo", new String[]{"Toronto", "Berlín"});
            destinos.Add("Ciudad-Templado-1-2 semanas-30-50 años-Cultura y Museos-Hostal o Albergue", new String[]{"Ciudad de México", "Madrid"});
            destinos.Add("Ciudad-Templado-1-2 semanas-Más de 50 años-Cultura y Museos-Hotel de Lujo", new String[]{"Nueva York", "París"});
            destinos.Add("Ciudad-Templado-Menos de una semana-Menos de 30 años-Relax y Bienestar-Airbnb", new String[]{"Miami", "Viena"});
            destinos.Add("Ciudad-Templado-Menos de una semana-30-50 años-Deportes y Aventuras-Hotel de Lujo", new String[]{"Chicago", "Londres"});

            String key = string.Join("-", Destino, Climatica, Viaje, Edad, Actividad, Alojamiento);
            String[] destino;
            if (!destinos.TryGetValue(key, out destino))
            {
                destino = new String[] { "Bora Bora", "Dubái" };
            }

            DestinoA = destino[0];
            DestinoE = destino[1];

            DestinationResponse destinationResponse = new DestinationResponse();
            Result result = new Result();
            Answer answer = new Answer();

            destinationResponse.DestinoA = DestinoA;
            destinationResponse.DestinoE = DestinoE;

            result.CityAmerica = DestinoA;
            result.CityEurope = DestinoE;

            //User user = UserRepository.GetUserById(destinationRequest.UserId);

            answer = Mappers.RequestMappers.MapToDestinationRequest(destinationRequest);

            await answerRepository.CreateAnswer(answer);

            result.AnswerId = answer.Id;

            await resultRepository.CreateResult(result);

            
            return destinationResponse;

            
        }
    }
}