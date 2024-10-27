using RealTimeWeatherMonitoringSystem.Bots;
using RealTimeWeatherMonitoringSystem.Config;
using RealTimeWeatherMonitoringSystem.Weather.Models;
using System.Linq;

namespace RealTimeWeatherMonitoringSystem.Station;

public class WeatherStation
{
    private List<IBaseBot> _bots = new();

    public WeatherStation(IBotConfiguration systemBots)
    {
        _bots.Add(systemBots.SnowBot);
        _bots.Add(systemBots.SunBot);
        _bots.Add(systemBots.RainBot);
    }

    public void AddBot(IBaseBot bot)
    {
        _bots.Add(bot);
    }
    public void Notify(IWeatherData weatherData)
    {
        foreach (var bot in _bots)
        {
            bot.Activate(weatherData);
        }
    }
}
