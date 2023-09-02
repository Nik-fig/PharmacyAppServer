namespace PharmacyAppServer.Models
{
    public class Deliveries
    {
        public int Id { get; set; }
        public Drug Drug { get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }

    }
}
