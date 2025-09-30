var builder = WebApplication.CreateBuilder(args);

builder.Services.AddControllersWithViews();

var app = builder.Build();

if (app.Environment.IsDevelopment())
{
    app.UseDeveloperExceptionPage();
}

app.UseStaticFiles();  // *** ÖNEMLİ: Statik dosyaları wwwroot’tan servis et ***

app.MapDefaultControllerRoute();  // Varsayılan MVC route’u

//? Alternatif (eşdeğer):
// app.MapControllerRoute(
//     name: "default",
//     pattern: "{controller=Home}/{action=Index}/{id?}");

app.Run();

/*
Program.cs

Uygulamanın başlangıç (entry point) dosyasıdır.

Web sunucusunu başlatır ve gerekli temel ayarları yapar. */