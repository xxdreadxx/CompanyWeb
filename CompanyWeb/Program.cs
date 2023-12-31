﻿var builder = WebApplication.CreateBuilder(args);

// Add services to the container.
builder.Services.AddControllersWithViews().AddRazorRuntimeCompilation();
builder.Services.AddRazorPages();

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
//app.UseMvcWithDefaultRoute();
app.UseAuthorization();

//app.MapControllerRoute(
//    name: "Admin",
//    pattern: "{area:exists}/{controller=AdHome}/{action=Index}/{id?}");

app.MapControllerRoute(
    name: "Login",
    pattern: "{controller=Home}/{action=Login}");

app.MapControllerRoute(
    name: "area",
    pattern: "{area:exists}/{controller}/{action}/{id?}");

app.MapControllerRoute(
    name: "default",
    pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();