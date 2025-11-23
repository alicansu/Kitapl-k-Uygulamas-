using Microsoft.AspNetCore.Builder;
using Microsoft.Extensions.DependencyInjection;
using Microsoft.Extensions.Hosting;

namespace Kitaplik2.WebUI
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            // --- EKLENEN KISIM BAÞLANGIÇ ---
            // Projen bir MVC projesi olduðu için bu servisi MUTLAKA eklemelisin.
            // Aksi takdirde Controller'lar ve View'lar (Layout dahil) düzgün çalýþmaz.
            builder.Services.AddControllersWithViews();
            // --- EKLENEN KISIM BÝTÝÞ ---

            // Razor Pages servisi (Eðer Razor Pages kullanmýyorsan bunu silebilirsin ama durmasýnýn zararý yok)
            builder.Services.AddRazorPages();

            var app = builder.Build();

            // Hata yönetimi ortam ayarlarý
            if (!app.Environment.IsDevelopment())
            {
                app.UseExceptionHandler("/Error");
                app.UseHsts();
            }

            app.UseHttpsRedirection();
            app.UseStaticFiles();

            app.UseRouting();
            app.UseAuthorization();

            // Rotalarý tanýmlýyoruz
            app.MapRazorPages();

            app.MapControllerRoute(
                name: "default",
                pattern: "{controller=Home}/{action=Index}/{id?}");

            app.Run();
        }
    }
}