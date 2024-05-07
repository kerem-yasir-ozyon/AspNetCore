namespace SuperMarketResimApp.Data.Entities
{
    public class Urun
    {
        public int Id { get; set; }
        public string Ad { get; set; }
        public double Fiyat { get; set; }
        public bool StokDurumu { get; set; }
        public string? ResimAdi { get; set; }
        public DateTime EklenmeTarihi { get; set; }
        public DateTime? GuncellenmeTarihi { get; set; }
    }
}
