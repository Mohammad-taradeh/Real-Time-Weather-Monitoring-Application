using RealTimeWeatherMonitoringSystem.Weather.Models;
using System.Text;

namespace RealTimeWeatherMonitoringSystem.Weather.Readers.Factory;

public class WeatherReaderFactory : IWeatherReaderFactory
{

    public IWeatherData? GetWeatherData(StringBuilder sb)
    {
        IWeatherReader reader;
        var inputType = DetermineTheDataType(sb);
        if (inputType == InputDataType.Json)
        {
            reader = new JsonWeatherReader();
        }
        else if (inputType == InputDataType.XML)
        {
            reader = new XmlWeatherReader();
        }
        else
        {
            throw new InvalidDataException("Provided data is neither Json nor XML.");
        }
        return reader.ReadWeather(sb);
    }
    private InputDataType? DetermineTheDataType(StringBuilder sb)
    {
        var IsJson = sb.ToString().Trim().Contains("{");
        var IsXML = sb.ToString().Trim().Contains("<");
        if (IsJson)
            return InputDataType.Json;
        else if (IsXML)
            return InputDataType.XML;
        return InputDataType.UNDEFINED;
    }
}
