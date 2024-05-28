using System;
using System.Collections.Generic;
using System.Net.Http;
using System.Net.Http.Json;
using System.Threading.Tasks;
using SeamlessEscapesBlazor.Models;

public class HotelService
{
    private readonly HttpClient _httpClient;
    private readonly string _apiKey = "YOUR_HOTELAPI_KEY"; // Replace with your actual API key

    public HotelService(HttpClient httpClient)
    {
        _httpClient = httpClient;
    }

    public async Task<List<Hotel>> GetHotelsAsync(string city, DateTime checkInDate, DateTime checkOutDate)
    {
        var requestUri = $"https://api.hotelapi.io/hotels/{_apiKey}/{city}/{checkInDate:yyyy-MM-dd}/{checkOutDate:yyyy-MM-dd}";
        var response = await _httpClient.GetFromJsonAsync<ApiResponse>(requestUri);

        var hotels = new List<Hotel>();

        if (response != null && response.hotels != null)
        {
            foreach (var hotel in response.hotels)
            {
                hotels.Add(new Hotel
                {
                    HotelId = hotel.hotelId,
                    HotelName = hotel.hotelName,
                    Address = hotel.address,
                    PricePerNight = hotel.pricePerNight
                });
            }
        }

        return hotels;
    }

    public class ApiResponse
    {
        public List<HotelResponse> hotels { get; set; }
    }

    public class HotelResponse
    {
        public int hotelId { get; set; }
        public string hotelName { get; set; }
        public string address { get; set; }
        public double pricePerNight { get; set; }
    }
}
