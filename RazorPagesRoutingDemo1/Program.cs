using RazorPagesRoutingDemo1.Data;
using RazorPagesRoutingDemo1.Services;
using Microsoft.EntityFrameworkCore;


var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorPages();
builder.Services.AddScoped<IProductService, ProductService>();


// Register Razor Pages
builder.Services.AddRazorPages();
builder.Services.AddScoped<IProductService, ProductService>();

builder.Services.AddRazorPages();
builder.Services.AddScoped<IProductService, ProductService>();


builder.Services.AddDbContext<ApplicationDbContext>(options =>
    options.UseSqlite(builder.Configuration.GetConnectionString("DefaultConnection")));

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