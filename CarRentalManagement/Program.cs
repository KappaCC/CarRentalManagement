using CarRentalManagement.Components;
using Microsoft.EntityFrameworkCore;
using Microsoft.Extensions.DependencyInjection;
using CarRentalManagement.Data;

var builder = WebApplication.CreateBuilder(args);

// Use the CarRentalManagementContext ONLY (NO IdentityContext)
builder.Services.AddDbContext<CarRentalManagementContext>(options =>
    options.UseSqlServer(
        builder.Configuration.GetConnectionString("CarRentalManagementContext")
        ?? throw new InvalidOperationException("Connection string 'CarRentalManagementContext' not found.")
    ));

builder.Services.AddQuickGridEntityFrameworkAdapter();

builder.Services.AddDatabaseDeveloperPageExceptionFilter();

// Add services for Razor Components
builder.Services.AddRazorComponents()
    .AddInteractiveServerComponents();

var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Error", createScopeForErrors: true);
    app.UseHsts();
    app.UseMigrationsEndPoint();
}

app.UseHttpsRedirection();
app.UseStaticFiles();
app.UseAntiforgery();

app.MapRazorComponents<App>()
    .AddInteractiveServerRenderMode();

app.Run();

