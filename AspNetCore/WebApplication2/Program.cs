namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews(); // controller için view yapýsýný entegre etmek
            var app = builder.Build(); // build yapmazsak manupile edemeyiz

            //app.MapGet("/", () => "Hello World!");

            app.UseHttpsRedirection(); // güvenli siteye otomatik yönlendiri yazýlmazsa güvenli olmadan baþka url de acýlabilir

            app.UseStaticFiles(); //statik dosyalarý kullanmak için gerekli ayarlar için

            app.MapDefaultControllerRoute(); // controller yapýsýna uygun rotayý

            app.Run();
        }
    }
}
