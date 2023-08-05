using System.Reflection;
using api;
using api.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using Serilog;
using Serilog.Events;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = builder.Configuration.Get<AppConfiguration>()?? throw new Exception("Configuration is not available");

var resourceKey = configuration.AzureTranslate.Key;
var region = configuration.AzureTranslate.Region;
var endpoint = configuration.AzureTranslate.Endpoint;

builder.Services.AddSingleton(configuration);
builder.Services.AddHttpClient("Azure_Translate", options =>
           {
               options.BaseAddress = new Uri(configuration.AzureTranslate.Endpoint);
               options.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", resourceKey);
               options.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Region", region);
           });
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
builder.Services.AddFluentValidationAutoValidation();

builder.Services.AddTransient<ITranslateService, TranslateService>();


// Configure Serilog
Log.Logger = new LoggerConfiguration()
    .MinimumLevel.Information()
    // Set the minimum log level here
    .WriteTo.File("Log/log.log", rollingInterval: RollingInterval.Day, restrictedToMinimumLevel: LogEventLevel.Information)
    // File logging configuration
    .CreateLogger();

builder.Services.AddLogging(builder =>
{
    builder.AddSerilog(dispose: true);
    // Use Serilog for logging
});
builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors(p => p.AllowAnyHeader()
                  .AllowAnyMethod()
                  .AllowAnyOrigin());
app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
