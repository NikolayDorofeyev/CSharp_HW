using Part2_HW1;
using Part2_HW1.Interfaces;

RequestDelegate next;
var builder = WebApplication.CreateBuilder(args);

// Add services to the container.

builder.Services.AddControllers();
// Learn more about configuring Swagger/OpenAPI at https://aka.ms/aspnetcore/swashbuckle
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddTransient<IManagementCars, ManagementCars>();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (app.Environment.IsDevelopment())
{
    app.UseSwagger();
    app.UseSwaggerUI();
}

app.UseRouting();

app.MapGet("/car/{carId}/name", (int carId, IManagementCars managementCars) => managementCars.GetCarName(carId));

app.MapGet("/car/{carId}/engine", (int carId, IManagementCars managementCars) => managementCars.GetCarEngine(carId));

app.MapGet("/car/{carId}/age", (int carId, IManagementCars managementCars) => managementCars.GetCarAge(carId));


app.UseHttpsRedirection();

app.UseAuthorization();

app.MapControllers();

app.Run();
