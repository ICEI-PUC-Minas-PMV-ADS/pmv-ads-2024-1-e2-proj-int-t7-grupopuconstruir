using Microsoft.EntityFrameworkCore;
using PUConstruir.Data;
using PUConstruir.Repositorio;

var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews();

builder.Services.AddSqlServer<BancoContext>(builder.Configuration.GetConnectionString("DataBase"));

builder.Services.AddScoped<IMaterialRepositorio, MaterialRepositorio>();

builder.Services.AddScoped<IProjetoRepositorio, ProjetoRepositorio>();

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

app.UseAuthorization();

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Index}/{action=Index}/{id?}");

app.Run();
