using System.ComponentModel.DataAnnotations;

namespace OtelApp.Models
{
    public class OtelListViewModel
    {
        public int Id { get; set; }
        public int SiraNo { get; set; }
        public string Adi { get; set; }
        public string Turu { get; set; }
        public byte YildizSayisi { get; set; }
        public int Kapasite { get; set; }
        public string OdaSayisi { get; set; }
        public string Islemler { get; set; }
        public Durumu OtelDurumu { get; set; }


    }
    public enum Durumu
    {
        Bos = 1,
        Dolu
    }
}
