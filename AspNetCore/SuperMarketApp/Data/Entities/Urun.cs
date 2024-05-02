using System.ComponentModel.DataAnnotations;

namespace SuperMarketApp.Data.Entities
{
    public class Urun
    {
        public int Id { get; set; }
        public string UrunAdi { get; set; }

        public double UrunFiyati { get; set; }
        public bool StokDurumu { get; set; }
    }
    
}
