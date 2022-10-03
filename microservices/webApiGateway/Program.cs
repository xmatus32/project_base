using Ocelot.DependencyInjection; //For Dependency Injection
using Ocelot.Middleware; //For middleware

IConfiguration configuration = new ConfigurationBuilder()
                            .AddJsonFile("ocelot.json")
                            .Build();

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();

builder.Services.AddCors(policyBuilder =>
    policyBuilder.AddPolicy("AllowLocalhost", 
            x=> x.AllowAnyMethod()
            .AllowAnyHeader()
            .SetIsOriginAllowed(origin => new Uri(origin).Host == "localhost")
            .AllowCredentials()));

builder.Services.AddOcelot(configuration);

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}
app.UseCors("AllowLocalhost");

app.UseOcelot().Wait();

// app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run("http://+:7000");
