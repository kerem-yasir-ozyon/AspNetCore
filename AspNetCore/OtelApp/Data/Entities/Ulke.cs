namespace OtelApp.Data.Entities
{
    public class Ulke
    {
        public int Id { get; set; }
        public string Name { get; set; }
        public string Description { get; set; }
        public bool IsActive { get; set; }
        public ICollection<Sehir>? Sehirler { get; set; }
    }
}
