using BankingApp3Tier.Data;
using BankingApp3Tier.DAL;
using BankingApp3Tier.BLL;
using Microsoft.EntityFrameworkCore;

var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

// DbContext
builder.Services.AddDbContext<BankingContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("BankingDb")));

// Repositories & Services
builder.Services.AddScoped<AccountRepository>();
builder.Services.AddScoped<AccountService>();

var app = builder.Build();

if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Banking}/{action=Index}/{id?}");

app.Run();
