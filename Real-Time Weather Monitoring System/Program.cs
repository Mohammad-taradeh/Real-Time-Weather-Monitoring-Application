using Real_Time_Weather_Monitoring_System.Config;
using Real_Time_Weather_Monitoring_System.Station;
using Real_Time_Weather_Monitoring_System.Weather.models;
using Real_Time_Weather_Monitoring_System.Weather.Readers.Factory;
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
        IWeatherData weatherData = readerFactory.GetWeatherData(sb);
        station.Notify(weatherData);

    }
}