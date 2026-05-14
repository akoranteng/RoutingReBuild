using RazorPagesRoutingDemo1.Services;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IProductService, ProductService>();


// Register Razor Pages
builder.Services.AddRazorPages();
builder.Services.AddScoped<IProductService, ProductService>();


var app = builder.Build();

// Configure the HTTP request pipeline
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error");
}

app.UseStaticFiles();

app.UseRouting();

// Map Razor Pages endpoints
app.MapRazorPages();

app.Run();