using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SeamlessEscapesBlazor.Models;

public class FlightService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "Api_key_in_discord"; // Replace with your actual API key

    public FlightService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Flight>> GetRoundTripFlightsAsync(string source, string destination, DateTime departureDate, DateTime returnDate)
    {
        var requestUri = $"https://api.flightapi.io/roundtrip/{_apiKey}/{source}/{destination}/{departureDate:yyyy-MM-dd}/{returnDate:yyyy-MM-dd}/1/EC/0/0";
        var response = await _httpClient.GetFromJsonAsync<ApiResponse>(requestUri);

        var flights = new List<Flight>();

        if (response != null && response.legs != null)
        {
            foreach (var leg in response.legs)
            {
                foreach (var segment in leg.segments)
                {
                    var flight = new Flight
                    {
                        FlightNumber = segment.designatorCode,
                        Airline = segment.airlineCode,
                        DepartureAirport = segment.departureAirportCode,
                        ArrivalAirport = segment.arrivalAirportCode,
                        DepartureTime = DateTime.Parse(segment.departureDateTime),
                        ArrivalTime = DateTime.Parse(segment.arrivalDateTime),
                        Description = $"Duration: {segment.durationMinutes} minutes, Stopover: {segment.stopoverDurationMinutes} minutes"
                    };
                    flights.Add(flight);
                }
            }
        }

        return flights;
    }

    public class ApiResponse
    {
        public List<Leg> legs { get; set; }
    }

    public class Leg
    {
        public string id { get; set; }
        public List<Segment> segments { get; set; }
    }

    public class Segment
    {
        public string departureAirportCode { get; set; }
        public string arrivalAirportCode { get; set; }
        public string airlineCode { get; set; }
        public string designatorCode { get; set; }
        public string departureDateTime { get; set; }
        public string arrivalDateTime { get; set; }
        public int durationMinutes { get; set; }
        public int stopoverDurationMinutes { get; set; }
    }
}
