using CompanyMangment.Application.Abstractions.Services;
using CompanyMangment.Application.Services;
using CompanyMangment.Infrastructure.Data;
using CompanyMangment.Infrastructure.Repositories.Base;
using CompanyMangment.Infrastructure.Repositories.Emoloyees;
using CompanyMangment.Infrastructure.Repositories.Roles;
using CompanyMangment.Infrastructure.Repositories.Users;
using Microsoft.EntityFrameworkCore;
using System;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddDbContext<AppDbContext>(options =>
    options.UseSqlServer(builder.Configuration.GetConnectionString("DefaultDatabase")));

builder.Services.AddScoped(typeof(IRepository<>), typeof(Repository<>));
builder.Services.AddScoped(typeof(IEmployeeRepository), typeof(EmployeeRepository));
builder.Services.AddScoped(typeof(IUserRepository), typeof(UserRepository));
builder.Services.AddScoped(typeof(IRoleRepository), typeof(RoleRepository));
builder.Services.AddScoped(typeof(IUnitOfWork), typeof(UnitOfWork));

builder.Services.AddScoped(typeof(IEmployeeService), typeof(EmployeeService));


var app = builder.Build();

// Configure the HTTP request pipeline.
if (!app.Environment.IsDevelopment())
{
    app.UseExceptionHandler("/Home/Error");
    app.UseHsts();
}

app.UseHttpsRedirection();
app.UseRouting();

app.UseAuthorization();

app.MapStaticAssets();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}")
    .WithStaticAssets();


app.Run();
