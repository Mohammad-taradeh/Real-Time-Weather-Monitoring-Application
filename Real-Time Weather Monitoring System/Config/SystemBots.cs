using System.Text.Json;

namespace RealTimeWeatherMonitoringSystem.Config;

public sealed class SystemBots
{
    private static readonly Lazy<IBotConfiguration> _configuration = new Lazy<IBotConfiguration>(()=>ReadConfigrationBots());
    private SystemBots()
    {
        
    }
    private static IBotConfiguration? ReadConfigrationBots()
    {
        string config = File.ReadAllText(@"C:/Users/Lenovo/source/repos/Real-Time Weather Monitoring System/Real-Time Weather Monitoring System/Config/Config.json");
        JsonSerializerOptions options = new();
        options.PropertyNameCaseInsensitive = true;
        return JsonSerializer.Deserialize<BotConfiguration>(config,options);
    }

    public static IBotConfiguration Instance { get { return _configuration.Value; } }

}
