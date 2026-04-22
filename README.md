# MinimalApiDemo – Geocoding + Weather + Forecast Services

This branch implements a modular Minimal API that integrates:
- Reverse geocoding (Nominatim)
- Current weather (Open-Meteo)
- Multi‑day forecast (Open-Meteo)
- Clean service architecture with DI
- Strongly typed models for all responses

The goal is to demonstrate clean routing, service separation, and real‑world API consumption in a Minimal API format.

---

## 📁 Project Structure

MinimalApiDemo/
│
├── Models/
│   ├── ReverseGeocodingResponse.cs
│   ├── WeatherResponse.cs
│   ├── ForecastResponse.cs
│
├── Services/
│   ├── ReverseGeocodingService.cs
│   ├── WeatherService.cs
│   ├── ForecastService.cs
│
└── Program.cs

Each service is isolated, testable, and registered via dependency injection.

---

## 🌍 Reverse Geocoding (Nominatim)

### **Endpoint**
`GET /reverse-geocode?lat={lat}&lon={lon}`

### **Description**
Takes latitude/longitude and returns:
- City
- State
- Country
- Display name

### **Example Response**
```json
{
  "city": "Boston",
  "state": "Massachusetts",
  "country": "United States",
  "displayName": "Boston, Suffolk County, Massachusetts, USA"
}

☀️ Current Weather (Open-Meteo)
Endpoint
GET /weather?lat={lat}&lon={lon}

Description
Returns current:

Temperature

Wind speed

Weather code

Time of observation

Example Response
{
  "temperature": 12.3,
  "windspeed": 5.4,
  "weathercode": 3,
  "time": "2024-04-21T15:00"
}

📅 Multi‑Day Forecast (Open-Meteo)
Endpoint
GET /forecast?lat={lat}&lon={lon}&days={n}

Description
Returns daily:

Max temperature

Min temperature

Weather code

Example Response
{
  "days": [
    { "date": "2024-04-22", "tempMax": 15.2, "tempMin": 7.1, "weathercode": 2 },
    { "date": "2024-04-23", "tempMax": 17.8, "tempMin": 8.4, "weathercode": 3 }
  ]
}

🧩 Dependency Injection Setup
builder.Services.AddScoped<ReverseGeocodingService>();
builder.Services.AddScoped<WeatherService>();
builder.Services.AddScoped<ForecastService>();

Each service uses HttpClient and strongly typed models for clean deserialization.
🚀 Routing Overview
app.MapGet("/reverse-geocode", async (...) => { ... });
app.MapGet("/weather", async (...) => { ... });
app.MapGet("/forecast", async (...) => { ... });


