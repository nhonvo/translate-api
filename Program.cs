using System.Reflection;
using api;
using api.Services;
using FluentValidation;
using FluentValidation.AspNetCore;
using api.Extensions;
using api.Middlewares;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = builder.Configuration.Get<AppConfiguration>() ?? throw new Exception("Configuration is not available");

var resourceKey = configuration.AzureTranslate.Key;
var region = configuration.AzureTranslate.Region;
var endpoint = configuration.AzureTranslate.Endpoint;

builder.Services.AddSingleton(configuration);
builder.Services.AddSingleton<GlobalExceptionMiddleware>();
builder.Services.AddTransient<ITranslateService, TranslateService>();

// client
builder.Services.AddHttpClient("Azure_Translate", options =>
           {
               options.BaseAddress = new Uri(configuration.AzureTranslate.Endpoint);
               options.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Key", resourceKey);
               options.DefaultRequestHeaders.Add("Ocp-Apim-Subscription-Region", region);
           });

builder.Services.AddControllers();
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
// validation
builder.Services.AddValidatorsFromAssembly(Assembly.GetExecutingAssembly());
builder.Services.AddFluentValidationAutoValidation();

// custom services
builder.Services.AddLog();
builder.Services.AddRateLimit();
builder.Services.AddCorsCustom();

var app = builder.Build();

app.UseSwagger();
app.UseSwaggerUI();
app.UseCors();
app.UseHttpsRedirection();
app.UseAuthorization();
app.MapControllers();
app.UseMiddleware<GlobalExceptionMiddleware>();

app.Run();
