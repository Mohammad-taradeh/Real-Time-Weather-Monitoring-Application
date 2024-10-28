using RealTimeWeatherMonitoringSystem.Weather.Models;
using System.Text;

namespace RealTimeWeatherMonitoringSystem.Weather.Readers.Factory;

public class WeatherReaderFactory : IWeatherReaderFactory
{

    public IWeatherData? GetWeatherData(string data)
    {
        IWeatherReader reader;
        var inputType = DetermineTheDataType(data);
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
        return reader.ReadWeather(data);
    }
    private InputDataType? DetermineTheDataType(string data)
    {
        var IsJson = data.Trim().Contains("{");
        var IsXML = data.Trim().Contains("<");
        if (IsJson)
            return InputDataType.Json;
        else if (IsXML)
            return InputDataType.XML;
        return InputDataType.UNDEFINED;
    }
}
