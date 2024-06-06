using SeamlessEscapesBlazor.Models;
using Microsoft.EntityFrameworkCore;
using System.Collections.Generic;
using System.Linq;
using System.Threading.Tasks;
using SeamlessEscapesBlazor.Data;

namespace SeamlessEscapesBlazor.Services
{
    public class FlightService
    {
        private readonly ApplicationDbContext _context;

        public FlightService(ApplicationDbContext context)
        {
            _context = context;
        }

        public async Task<List<Flight>> GetRoundTripFlightsAsync(string source, string destination, DateTime departureDate, DateTime returnDate)
        {
            // For simplicity, assuming source and destination logic is handled elsewhere
            return await _context.Flights
                .Where(f => f.DepartureTime.Date == departureDate.Date || f.ArrivalTime.Date == returnDate.Date)
                .ToListAsync();
        }

        public async Task AddFlightAsync(Flight flight)
        {
            _context.Flights.Add(flight);
            await _context.SaveChangesAsync();
        }
    }
}