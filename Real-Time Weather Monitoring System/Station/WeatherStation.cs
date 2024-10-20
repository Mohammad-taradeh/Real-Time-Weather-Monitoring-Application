using Real_Time_Weather_Monitoring_System.Bots;
using Real_Time_Weather_Monitoring_System.Config;
using Real_Time_Weather_Monitoring_System.Weather.models;
using System.Linq;

namespace Real_Time_Weather_Monitoring_System.Station;

public class WeatherStation
{
    private List<IBaseBot> _bots = new();

    public WeatherStation(IBots systemBots)
    {
        _bots.Add(systemBots.snowBot);
        _bots.Add(systemBots.sunBot);
        _bots.Add(systemBots.rainBot);
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
