using System.ComponentModel.DataAnnotations;

namespace OtelApp.Data.Entities
{
    public class Otel
    {
        public int Id { get; set; }
        public string Adi { get; set; }
        public string Aciklama { get; set; }
        public OtelTuru OtelTuru { get; set; }
        public int OtelTuruId { get; set; }
        public byte YildizSayisi { get; set; }
        public string Adres { get; set; }
        public Ulke Ulke { get; set; }
        public int UlkeId { get; set; }
        public Sehir Sehir { get; set; }
        public int SehirId { get; set; }
        [DataType(DataType.PhoneNumber)]
        public int Telefon { get; set; }
        [DataType(DataType.EmailAddress)]
        public string Email { get; set; }
        public string? Logo { get; set; }
        
        public List<OtelKapasite> OtelKapasiteler { get; set; }
    }
}
