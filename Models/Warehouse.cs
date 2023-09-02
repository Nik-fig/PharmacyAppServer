namespace PharmacyAppServer.Models
{
    public class Warehouse
    {
        public int Id { get; set; }
        public Drug Drug { get; set; }
        public int Count { get; set; }
    }
}
