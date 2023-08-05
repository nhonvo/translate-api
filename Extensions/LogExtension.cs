using Serilog;
using Serilog.Events;
namespace api.Extensions;
public static class LogExtension
{
    public static IServiceCollection AddLog(this IServiceCollection services)
    {
        // Configure Serilog
        Log.Logger = new LoggerConfiguration()
            .MinimumLevel.Information()
            // Set the minimum log level here
            .WriteTo.File(
            "Log/log.log",
            rollingInterval: RollingInterval.Day,
            restrictedToMinimumLevel: LogEventLevel.Information)
            // File logging configuration
            .CreateLogger();

        services.AddLogging(builder =>
        {
            builder.AddSerilog(dispose: true);
            // Use Serilog for logging
        });
        return services;
    }
}