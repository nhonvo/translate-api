using api;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

var configuration = builder.Configuration.Get<AppConfiguration>();

builder.Services.AddSingleton(configuration);
builder.Services.AddHttpClient("Azure_Translate", options =>
           {
               options.BaseAddress = new Uri(configuration.AzureTranslate.Endpoint);
           });

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
