namespace OtelApp.Data.Entities
{
    public class OtelKapasite
    {
        public int Id { get; set; }
        public int Kapasite { get; set; }
        public int OtelId { get; set; }
        public Otel Otel { get; set; }
    }
}
