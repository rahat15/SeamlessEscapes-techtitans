using System;
using System.Collections.Generic;
using System.Threading.Tasks;
using SeamlessEscapesBlazor.Models;

public class FlightService
{
    public Task<List<Flight>> GetFlightsAsync(string source, string destination)
    {
        // Hardcoded list of flights
        var flights = new List<Flight>
        {
            new Flight
            {
                FlightNumber = "AB123",
                Airline = "Airline A",
                DepartureAirport = source,
                ArrivalAirport = destination,
                DepartureTime = DateTime.Now.AddDays(1).AddHours(3),
                ArrivalTime = DateTime.Now.AddDays(1).AddHours(5),
                Description = "Direct flight."
            },
            new Flight
            {
                FlightNumber = "CD456",
                Airline = "Airline B",
                DepartureAirport = source,
                ArrivalAirport = destination,
                DepartureTime = DateTime.Now.AddDays(2).AddHours(4),
                ArrivalTime = DateTime.Now.AddDays(2).AddHours(6),
                Description = "One stop. Meal included."
            }
        };

        // Simulate asynchronous operation
        return Task.FromResult(flights);
    }
}
