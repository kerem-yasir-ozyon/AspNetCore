using System.ComponentModel.DataAnnotations;

namespace OtelApp.Models
{
    public class OtelViewModel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public string Turu { get; set; }
        public byte YildizSayisi { get; set; }
        public string Adres { get; set; }
        public string Ulke { get; set; }
        public string Sehir { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Telefon  { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string? Logo { get; set; }
    }
}
