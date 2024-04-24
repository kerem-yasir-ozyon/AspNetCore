using Microsoft.AspNetCore.Mvc.ModelBinding;

namespace Example05.WebApplication.Models
{
    public class Student
    {
        public string Ad { get; set; }
        public string Soyad { get; set; }

        [BindNever]
        public string Eposta { get; set; }
        public string DTarihi { get; set; }
    }
}
