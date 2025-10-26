using Application;
using Domain;

namespace Back.Api;

public class WeatherService : IWeatherService
{
    public Task<WeatherData> GetWeatherAsync(string location)
    {
        // Dummy data
        return Task.FromResult(new WeatherData
        {
            Location = location,
            Temperature = 25.0 // Example temperature
        });
    }
}