using HostedServices;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddHostedService<MyBackgroundService>();
builder.Services.AddHostedService<MyHostedService>();

var app = builder.Build();

app.MapGet("/", () => "Hello World!");

app.Run();
