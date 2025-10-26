using Domain;

namespace Application;

public interface IWeatherService
{
    Task<WeatherData> GetWeatherAsync(string location);
}