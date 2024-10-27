using System.Text.Json;

namespace RealTimeWeatherMonitoringSystem.Config;

public sealed class SystemBots
{
    private static readonly Lazy<IBots> _configuration = new Lazy<IBots>(()=>ReadConfigrationBots());
    private SystemBots()
    {
        
    }
    private static IBots? ReadConfigrationBots()
    {
        string config = File.ReadAllText(@"C:/Users/Lenovo/source/repos/Real-Time Weather Monitoring System/Real-Time Weather Monitoring System/Config/Config.json");
        JsonSerializerOptions options = new();
        options.PropertyNameCaseInsensitive = true;
        return JsonSerializer.Deserialize<Bots>(config,options);
    }

    public static IBots Instance { get { return _configuration.Value; } }

}
