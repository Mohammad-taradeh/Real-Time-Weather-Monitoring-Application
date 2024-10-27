using RealTimeWeatherMonitoringSystem.Config;
using RealTimeWeatherMonitoringSystem.Station;
using RealTimeWeatherMonitoringSystem.Weather.Models;
using RealTimeWeatherMonitoringSystem.Weather.Readers.Factory;
using System.Text;

public static class Program
{
    public static void Main(string[] args)
    {

        WeatherStation station = new(SystemBots.Instance);
        Console.WriteLine("Enter weather data:");
        StringBuilder sb = new StringBuilder();
        string? input;
        while (true)
        {
            input = Console.ReadLine();
            if ( input != "STOP")
                sb.Append(input);
            else break;
        }

        WeatherReaderFactory readerFactory = new();
        var weatherData = readerFactory.GetWeatherData(sb);
        station.Notify(weatherData);

    }
}