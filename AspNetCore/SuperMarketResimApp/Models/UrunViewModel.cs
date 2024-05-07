namespace SuperMarketResimApp.Models
{
    public class UrunViewModel
    {
        public string Name { get; set; }
        public double Fiyat { get; set; }
        public bool StokDurumu { get; set; }
        public IFormFile Resim { get; set; }
    }
}
