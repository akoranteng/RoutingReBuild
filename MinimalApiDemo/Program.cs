using MinimalApiDemo.Services;

var builder = WebApplication.CreateBuilder(args);

// 1. Register Swagger services FIRST
builder.Services.AddEndpointsApiExplorer();
builder.Services.AddSwaggerGen();
builder.Services.AddSingleton<WeatherService>();
builder.Services.AddHttpClient<ReverseGeocodingService>();
builder.Services.AddHttpClient<ForecastService>();




// 2. Build the app
var app = builder.Build();

// 3. Enable Swagger middleware AFTER building
app.UseSwagger();
app.UseSwaggerUI();

// 4. Your endpoints go here



// ------------------------------
// Module 01: Minimal API Routing
// ------------------------------

// GET /hello
app.MapGet("/hello", () =>
    Results.Ok(new { Message = "Hello from Minimal API!" })
);

// GET /products/{id}
app.MapGet("/products/{id:int}", (int id) =>
    Results.Ok(new { Id = id, Name = $"Product {id}" })
);

// GET /search?term=abc
//Define endpoint handler, pass in query string parameter
//
app.MapGet("/search", (string? term) =>
{
    if (string.IsNullOrWhiteSpace(term))
        return Results.BadRequest(new { Error = "Search term is required." });

    return Results.Ok(new
    {
        Term = term,
        Results = new[] { "A", "B", "C" }
    });
});

// POST /products
app.MapPost("/products", (Product product) =>
    Results.Created($"/products/{product.Id}", product)
);

// PUT /products/{id}
app.MapPut("/products/{id:int}", (int id, Product updated) =>
    Results.Ok(new
    {
        Message = $"Product {id} updated.",
        Updated = updated
    })
);

// DELETE /products/{id}
app.MapDelete("/products/{id:int}", (int id) =>
    Results.Ok(new { Message = $"Product {id} deleted." })
);

#region ConversionEndpoints

// Celsius → Fahrenheit
app.MapGet("/convert/c-to-f", (double c) =>
{
    double f = (c * 9 / 5) + 32;
    return Results.Ok(new { Celsius = c, Fahrenheit = f });
});

// Fahrenheit → Celsius
app.MapGet("/convert/f-to-c", (double f) =>
{
    double c = (f - 32) * 5 / 9;
    return Results.Ok(new { Fahrenheit = f, Celsius = c });
});

// Miles → Kilometers
app.MapGet("/convert/miles-to-km", (double miles) =>
{
    double km = miles * 1.60934;
    return Results.Ok(new { Miles = miles, Kilometers = Math.Round(km, 2) });
});

// Kilometers → Miles
app.MapGet("/convert/km-to-miles", (double km) =>
{
    double miles = km / 1.60934;
    return Results.Ok(new { Kilometers = km, Miles = Math.Round(miles, 2) });
});



#endregion

#region WeatherEndpoints

// Simple mock weather by city
app.MapGet("/weather/by-city", (string city) =>
{
    var data = new
    {
        City = city,
        TemperatureC = 22,
        TemperatureF = Math.Round((22 * 9.0 / 5.0) + 32, 1),
        Condition = "Sunny",
        Humidity = 40,
        WindKph = 12
    };

    return Results.Ok(data);
});

// Simple mock weather by coordinates



app.MapGet("/weather/live/{lat:double}/{lon:double}", async (double lat, double lon, WeatherService service) =>
{
    var weather = await service.GetWeatherAsync(lat, lon);
    return Results.Ok(weather);
});

app.MapGet("/weather/forecast/{lat}/{lon}", async (double lat, double lon, ForecastService forecastService) =>
{
    var forecast = await forecastService.GetForecastAsync(lat, lon);
    return Results.Ok(forecast);
});



#endregion


app.Run();

record Product(int Id, string Name);
