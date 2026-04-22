

🧩 Dependency Injection Setup
builder.Services.AddScoped<ReverseGeocodingService>();
builder.Services.AddScoped<WeatherService>();
builder.Services.AddScoped<ForecastService>();
=======


Each service uses HttpClient and strongly typed models for clean deserialization.
🚀 Routing Overview
app.MapGet("/reverse-geocode", async (...) => { ... });
app.MapGet("/weather", async (...) => { ... });
app.MapGet("/forecast", async (...) => { ... });


