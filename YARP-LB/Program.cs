var builder = WebApplication.CreateBuilder(args);

builder.Services.AddReverseProxy()
    .LoadFromConfig(builder.Configuration.GetSection("YARP"));

var app = builder.Build();

app.MapGet("/api", () => Results.Ok("Hello from YARP"));

app.MapReverseProxy();

app.Run();
