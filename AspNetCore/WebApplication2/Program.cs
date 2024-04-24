namespace WebApplication2
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);

            builder.Services.AddControllersWithViews(); // controller i�in view yap�s�n� entegre etmek
            var app = builder.Build(); // build yapmazsak manupile edemeyiz

            //app.MapGet("/", () => "Hello World!");

            app.UseHttpsRedirection(); // g�venli siteye otomatik y�nlendiri yaz�lmazsa g�venli olmadan ba�ka url de ac�labilir

            app.UseStaticFiles(); //statik dosyalar� kullanmak i�in gerekli ayarlar i�in

            app.MapDefaultControllerRoute(); // controller yap�s�na uygun rotay�

            app.Run();
        }
    }
}
