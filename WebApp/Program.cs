using WebApp.Classes;
using WebApp.Interfaces;
using WebApp.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddTransient<ICounter, RandomCounter>();
builder.Services.AddScoped<CounterService>();
builder.Services.AddSingleton<ITimeService, LongTimeService>();


var app = builder.Build();

app.UseMiddleware<CounterMiddleware>();

//app.Run(async context =>
//{
//    var time = app.Services.GetService<ITimeService>();
//    var count = app.Services.GetService<ICounter>();

//    await context.Response.WriteAsync($"Count: {count?.Count}");
//    await context.Response.WriteAsync($"\n");
//    await context.Response.WriteAsync($"Time: {time?.GetUtcTime()}");
//});


// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();

app.UseAuthorization();

app.MapRazorPages();

app.Run();
