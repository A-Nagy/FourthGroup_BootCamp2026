
using FourthGroup_1.Data;
using FourthGroup_1.Models;
using FourthGroup_1.Repositories.Base;
using FourthGroup_1.Repositories.Emoloyee;
using FourthGroup_1.Repositories.Roles;
using FourthGroup_1.Repositories.Users;
using FourthGroup_1.Security;
using Microsoft.AspNetCore.Authentication.Cookies;
using Microsoft.EntityFrameworkCore;
using System.Threading.RateLimiting;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultConnection")));

builder.Services.AddScoped(typeof(IRepository<>),typeof(Repository<>));
builder.Services.AddScoped(typeof(IEmployeeRepository), typeof(EmployeeRepository));
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddScoped(typeof(IRoleRepository), typeof(RoleRepository));

builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));





builder.Services.AddAuthentication(
    CookieAuthenticationDefaults.AuthenticationScheme).AddCookie(options => 
    {
        options.LoginPath = "/Account/Login";
        options.AccessDeniedPath = "/Account/AccessDenied";
        options.ExpireTimeSpan = TimeSpan.FromMinutes(30);
        options.SlidingExpiration=true;
        options.Cookie.Name = "CompanyManagement.Auth";
        options.Cookie.HttpOnly=true;
    });

builder.Services.AddAuthorization(
    options => {
        foreach (string permission in PermissionsNames.All) 
        {
            options.AddPolicy(permission,
                policy => policy.RequireClaim(PermissionsNames.ClaimType, permission));
        }
    }
    );


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

app.UseAuthentication();

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Account}/{action=Login}/{id?}");

app.Run();
