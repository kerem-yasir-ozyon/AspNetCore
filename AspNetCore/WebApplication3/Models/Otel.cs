using System.ComponentModel.DataAnnotations;

namespace WebApplication3.Models
{
    public class Otel
    {
        public int Id { get; set; }
        public string Adı { get; set; }
        public string Aciklama { get; set; }
        public string Turu { get; set; }
        public int Puan { get; set; }

        [DataType(DataType.EmailAddress)]

        public string Email { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Telefon { get; set; }
    }
}
