using AmadeusG3_Neo_Tech_BackEnd.Dtos.Request;
using Npgsql.Replication;
using AmadeusG3_Neo_Tech_BackEnd.Models;

namespace AmadeusG3_Neo_Tech_BackEnd.Mappers{

    public static class RequestMappers
    {
        public static Answer MapToDestinationRequest(DestinationRequest destinationRequest)
        {
            return new Answer
            {
                Destiny = destinationRequest.Destiny,
                Weather = destinationRequest.Weather,
                Activity = destinationRequest.Activity,
                Housing = destinationRequest.Housing,
                TravelTime = destinationRequest.TravelTime,
                Age = destinationRequest.Age,
                UserId = destinationRequest.UserId

            };
        }
    }
}