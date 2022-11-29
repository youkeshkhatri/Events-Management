using Events_Management.Models;
using Microsoft.AspNetCore.Authentication;
using Microsoft.EntityFrameworkCore;
using Microsoft.AspNetCore.Identity;
using Events_Management.Areas.Identity.Data;
using Microsoft.DotNet.Scaffolding.Shared.ProjectModel;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<EventsContext>
    (options => options.UseSqlServer
    (builder.Configuration.GetConnectionString("dbconn")));


builder.Services.AddDbContext<Events_Management_IdentityContext>
    (options => options.UseSqlServer
    (builder.Configuration.GetConnectionString("dbconn")));


builder.Services.AddDefaultIdentity<Events_ManagementUser>(options => options.SignIn.RequireConfirmedAccount = true)
    .AddEntityFrameworkStores<Events_Management_IdentityContext>();


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    // The default HSTS value is 30 days. You may want to change this for production scenarios, see https://aka.ms/aspnetcore-hsts.
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseStaticFiles();

app.UseRouting();
app.UseAuthentication();;

app.UseAuthorization();

app.MapRazorPages();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();
