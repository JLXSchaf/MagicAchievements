using MagicAchievements.Components;
using MagicAchievements.Interface;
using System.Net.NetworkInformation;
using static System.Net.WebRequestMethods;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddRazorComponents();

// Add appsettings with api addresses
builder.Services.AddScoped<IAppSettings>();

var app = builder.Build();

var state = app.Services.GetRequiredService<IAppSettings>();
// Apiadresses 
state.ApiUserData = "https://localhost:7139/api/User";
state.ApiAchievementsData = "https://localhost:7139/api/MagicAchievements";

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();


app.UseAntiforgery();

app.MapStaticAssets();
app.MapRazorComponents<App>();

app.Run();
