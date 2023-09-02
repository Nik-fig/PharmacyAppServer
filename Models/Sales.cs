using System;

namespace PharmacyAppServer.Models
{
    public class Sales
    {
        public int Id { get; set; }
        public Drug Drug {  get; set; }
        public int Count { get; set; }
        public DateTime Date { get; set; }
    }
}
