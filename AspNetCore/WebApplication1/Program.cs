using Microsoft.AspNetCore.Http;
using System.Net.Http;

namespace WebApplication1
{
    public class Program
    {
        public static void Main(string[] args)
        {
            var builder = WebApplication.CreateBuilder(args);
            builder.Services.AddControllersWithViews();
            var app = builder.Build();

            //app.MapGet("/", async (httpContext) =>
            //{
            //    await httpContext.Response.WriteAsync("<a href ='/hakkimizda'>hakkimizda</a><br>");
            //    await httpContext.Response.WriteAsync("<a href ='/iletisim'>iletisim</a><br>");
            //    await httpContext.Response.WriteAsync("<a href ='/projeler'>projeler</a><br>");
            //});



            //app.MapGet("/hakkimizda", async (httpContext) =>
            //{
            //    httpContext.Response.ContentType = "text/html; charset=utf-8";
            //    await httpContext.Response.WriteAsync("<b>hakkimizda sayfamýza hos geldiniz.</b><br>");
            //    await httpContext.Response.WriteAsync("<a href ='/'>Anasayfa</a><br>");

            //});

            //app.MapGet("/iletisim", async (httpContext) =>
            //{
            //    httpContext.Response.ContentType = "text/html; charset=utf-8";
            //    await httpContext.Response.WriteAsync("<b>iletisim sayfamýza hos geldiniz.</b><br>");
            //    await httpContext.Response.WriteAsync("<a href ='/'>Anasayfa</a><br>");

            //});

            //app.MapGet("/projeler", async (httpContext) =>
            //{
            //    httpContext.Response.ContentType = "text/html; charset=utf-8";
            //    await httpContext.Response.WriteAsync("<b>Projeler sayfamýza hos geldiniz.</b><br>");
            //    await httpContext.Response.WriteAsync("<a href ='/'>Anasayfa</a><br>");

            //});
            app.MapDefaultControllerRoute();


            app.Run(); 
        }
    }
}
